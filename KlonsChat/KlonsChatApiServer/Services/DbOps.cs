using KlonsChatDb.Models;
using KlonsChatDto.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace KlonsChatApiServer.Services
{
    public class DbOps
    {
        private readonly KlonsqDbContext DbCtx;
        private readonly IHubContext<SignalHub> Hub;

        public static string AdminGuid;

        public DbOps(KlonsqDbContext context, IHubContext<SignalHub> hub)
        {
            DbCtx = context;
            Hub = hub;
        }

        public async Task<bool> SendSignalToUser(string userid, string msg)
        {
            try
            {
                var userConnections = SignalHub.GetConnectionsForUser(userid);
                foreach (var connectionId in userConnections)
                    await Hub.Clients.Client(connectionId).SendAsync("ReceiveMessage", msg);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public async Task<AddItemsResult> AddItem(AddItemRequest reqdata)
        {
            var ret = new AddItemsResult();
            if (string.IsNullOrEmpty(reqdata.UserGuid) ||
                string.IsNullOrEmpty(reqdata.Content) ||
                reqdata.UserGuid.Length < 20)
            {
                ret.Result = EAddItemsResult.BadRequest;
                return ret;
            }
            if (reqdata.UserGuid.Length > 40 ||
                reqdata.Content.Length > 2000 ||
                (reqdata.SupportGuid != null && reqdata.SupportGuid.Length > 40))
            {
                ret.Result = EAddItemsResult.TooLong;
                return ret;
            }
            if (reqdata.SupportGuid != null && reqdata.SupportGuid != AdminGuid)
            {
                ret.Result = EAddItemsResult.NotAuthorized;
                return ret;
            }
            var user = await DbCtx.Users.FirstOrDefaultAsync(x => x.Guid == reqdata.UserGuid);
            if (user == null)
            {
                ret.Result = EAddItemsResult.UserCreated;
                user = new User()
                {
                    Guid = reqdata.UserGuid
                };
                DbCtx.Add(user);
            }
            else
            {
                ret.Result = EAddItemsResult.Ok;
            }
            
            var item = new Item()
            {
                User = user,
                Content = reqdata.Content,
                Type = EItemType.QuestionNew,
                DateCreated = DateTime.Now
            };
            if (reqdata.SupportGuid != null && reqdata.SupportGuid == AdminGuid)
            {
                item.Type = EItemType.Answer;
            }

            DbCtx.Add(item);
            await DbCtx.SaveChangesAsync();
            ret.Item = ItemMapper.Map(item);
            if (item.Type == EItemType.QuestionNew)
                await SendSignalToUser(AdminGuid, "Chat updated");
            return ret;
        }

        public async Task<GetItemsResult> GetItems(string userguid, int lastid)
        {
            var ret = new GetItemsResult();
            if (string.IsNullOrEmpty(userguid))
            {
                ret.Result = EGetItemsResult.UserNotFound;
                return ret;
            }
            var user = await DbCtx.Users
                .Where(x => x.Guid == userguid)
                .Include(x => x.Items
                    .Where(i => !i.IsDeleted && i.Id > lastid)
                    .OrderBy(e => e.DateCreated)
                    .ThenBy(e => e.Id))
                .FirstOrDefaultAsync();
            if (user == null)
            {
                ret.Result = EGetItemsResult.UserNotFound;
                ret.Items = [];
            }
            else
            {
                ret.Result = EGetItemsResult.Ok;
                ret.Items = ItemMapper.Map(user.Items);
            }
            return ret;
        }

        public async Task<GetUpdatedChatsResult> GetUpdatedChats(string userguid)
        {
            var ret = new GetUpdatedChatsResult();
            if (string.IsNullOrEmpty(userguid) ||
                userguid.Length < 20)
            {
                ret.Result = EGetUpdatedChatsResult.BadRequest;
                return ret;
            }
            if (userguid != AdminGuid)
            {
                ret.Result = EGetUpdatedChatsResult.NotAuthorized;
                return ret;
            }
            var list = await DbCtx.Users
                .Select(x => new
                {
                    uid = x.Guid,
                    count = x.Items.Count(z => !z.IsDeleted && z.Type == EItemType.QuestionNew)
                })
                .Where(x => x.count > 0)
                .ToListAsync();
            ret.UpdatedChatList = list.Select(x => new UpdatedChatData()
                {
                    UserGuid = x.uid,
                    NewItemCount = x.count
                })
                .ToList();
            ret.Result = EGetUpdatedChatsResult.Ok;
            return ret;
        }

        public async Task<ClearChatResponse> ClearChat(string userguid)
        {
            var ret = new ClearChatResponse();
            if (string.IsNullOrEmpty(userguid) ||
                userguid.Length < 20 ||
                userguid.Length > 40)
            {
                ret.Result = EClearChatResult.BadRequest;
                return ret;
            }
            var user = await DbCtx.Users.FirstOrDefaultAsync(x => x.Guid == userguid);
            if (user == null)
            {
                ret.Result = EClearChatResult.UserNotFound;
                return ret;
            }
            await DbCtx.Items
                .Where(x => x.UserId == user.Id)
                .ExecuteDeleteAsync();
            ret.Result = EClearChatResult.Ok;
            return ret;
        }

        public async Task<MarkChatAnsweredResponse> MarkChatAnswered(MarkChatAnsweredRequest req)
        {
            var ret = new MarkChatAnsweredResponse();
            if (string.IsNullOrEmpty(req.UserGuid) ||
                string.IsNullOrEmpty(req.SupportGuid) ||
                req.UserGuid.Length < 20 ||
                req.UserGuid.Length > 40 ||
                req.SupportGuid.Length < 20 ||
                req.SupportGuid.Length > 40)
            {
                ret.Result = EMarkChatAnsweredResult.BadRequest;
                return ret;
            }
            var user = await DbCtx.Users.FirstOrDefaultAsync(x => x.Guid == req.UserGuid);
            if (user == null)
            {
                ret.Result = EMarkChatAnsweredResult.UserNotFound;
                return ret;
            }
            await DbCtx.Items
                .Where(x => x.UserId == user.Id && x.Type == EItemType.QuestionNew)
                .ExecuteUpdateAsync(x => x.SetProperty(p => p.Type, p => EItemType.QuestionAnswered));
            ret.Result = EMarkChatAnsweredResult.Ok;
            return ret;
        }


    }
}
