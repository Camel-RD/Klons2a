using KlonsChatDto.Models;
using KlonsF.Classes;
using KlonsF.Properties;
using NPOI.SS.Formula.Functions;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KlonsF.ClassesChat
{
    public class ChatApi
    {
        IChatApi _ChatApi;
        ChatData ChatData = null;
        readonly string ChatFileName = KlonsData.St.ChatDataFileName;

        public ChatData GetChatData()
        {
            if (ChatData == null)
            {
                ChatData = ChatData.LoadChat(ChatFileName);
            }
            return ChatData;
        }

        void CheckChatApi()
        {
            if (_ChatApi == null)
            {
                GetChatData();
                InitRefit();
            }
        }

        void InitRefit()
        {
            var refitsettings = new RefitSettings();
            var serializeroptions = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = null
            };
            serializeroptions.Converters.Add(new ObjectToInferredTypesConverter());
            var customserializer = new SystemTextJsonContentSerializer(serializeroptions);
            refitsettings.ContentSerializer = customserializer;
            var serverurl = Settings.Default.ChatServerURL;
            _ChatApi = RestService.For<IChatApi>(serverurl, refitsettings);
        }

        public async Task<string> AddItem(string content)
        {
            CheckChatApi();
            content = content?.Trim();
            if (string.IsNullOrEmpty(content))
                return "Vispirms jāieraksta jautājums.";

            if (string.IsNullOrEmpty(ChatData.UserGuid))
            {
                var b = new byte[16];
                Random.Shared.NextBytes(b);
                ChatData.UserGuid = new Guid(b).ToString();
            }
            var req = new AddItemRequest()
            {
                Content = content,
                UserGuid = ChatData.UserGuid,
            };
            ChatData.LastChecked = DateTime.Now;
            try
            {
                var ret = await _ChatApi.AddItem(req);
                if (!ret.IsSuccessful || ret.Content.Result == EAddItemsResult.BadRequest ||
                    ret.Content.Item?.Content == null)
                {
                    return "Neizdevās nosūtīt jautājumu.";
                }
                var addeditem = ret.Content.Item;
                var nuewitems = ChatData.Add([addeditem]);
            }
            catch(Exception)
            {
                return "Neizdevās nosūtīt jautājumu.";
            }
            ChatData.SaveChat(ChatFileName);
            return "OK";
        }

        public async Task<string> UpdateChat()
        {
            CheckChatApi();
            if (string.IsNullOrEmpty(ChatData.UserGuid))
                return "Nav norādīts lietotāja identifikators.";
            int lastid = -1;
            if (ChatData.ChatItems != null && ChatData.ChatItems.Count > 0)
            {
                var lastitem = ChatData.ChatItems.Last();
                if (lastitem.Id != null)
                    lastid = lastitem.Id.Value;
            }
            ChatData.LastChecked = DateTime.Now;
            try
            {
                var ret = await _ChatApi.GetItems(ChatData.UserGuid, lastid);
                if (!ret.IsSuccessful || ret.Content.Result == EGetItemsResult.None)
                {
                    return "Neizdevās saņemt datus.";
                }
                if (ret.Content.Items != null && ret.Content.Items.Count > 0)
                {
                    var nuewitems = ChatData.Add(ret.Content.Items);
                }
            }
            catch(Exception)
            {
                return "Neizdevās nosūtīt jautājumu.";
            }
            ChatData.SaveChat(ChatFileName);
            return "OK";
        }

        public async Task<(bool, string)> ChatHasNewData()
        {
            CheckChatApi();
            ChatData.LastChecked = DateTime.Now;
            int itemcountbefore = ChatData.ChatItems.Count;
            try
            {
                var rt = await UpdateChat();
                if (rt != "OK")
                    return (false, rt);
            }
            catch(Exception)
            {
                return (false, "Neizdevās nosūtīt jautājumu.");
            }
            bool gotnews = ChatData.ChatItems.Count > itemcountbefore;
            return (gotnews, "OK");
        }

        public async Task<string> ClearChat()
        {
            CheckChatApi();
            if (string.IsNullOrEmpty(ChatData.UserGuid))
                return "Nav norādīts lietotāja identifikators.";
            ChatData.LastChecked = DateTime.Now;
            try
            {
                var ret = await _ChatApi.ClearChat(ChatData.UserGuid);
                if (!ret.IsSuccessful || ret.Content.Result == EClearChatResult.None)
                {
                    return "Neizdevās nosūtīt pieprasījumu.";
                }
            }
            catch(Exception)
            {
                return "Neizdevās nosūtīt jautājumu.";
            }
            ChatData.ChatItems.Clear();
            if (ChatData.HasChangesSettings())
                ChatData.SaveChat(ChatFileName);
            return "OK";
        }

    }
}
