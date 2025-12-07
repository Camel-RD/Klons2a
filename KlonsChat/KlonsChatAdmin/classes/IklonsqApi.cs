using KlonsChatDto.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsChatAdmin.classes
{
    public interface IklonsqApi
    {

        [Post("/item")]
        Task<ApiResponse<AddItemsResult>> AddItem([Body] AddItemRequest req);

        [Get("/items/{userguid}/{lastid}")]
        Task<ApiResponse<GetItemsResult>> GetItems(string userguid, int lastid);

        [Get("/clearchat/{userguid}")]
        Task<ApiResponse<ClearChatResponse>> ClearChat(string userguid);

        [Get("/updatedchats/{userguid}")]
        Task<ApiResponse<GetUpdatedChatsResult>> GetUpdatedChats(string userguid);

        [Post("/markchatanswered")]
        Task<ApiResponse<MarkChatAnsweredResponse>> MarkChatAnswered([Body] MarkChatAnsweredRequest req);

        [Get("/login/{userguid}")]
        Task<ApiResponse<string>> Login(string userguid);
    }

}
