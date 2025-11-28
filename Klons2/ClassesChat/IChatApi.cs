using KlonsChatDto.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsF.ClassesChat
{
    public interface IChatApi
    {
        [Post("/item")]
        Task<ApiResponse<AddItemsResult>> AddItem([Body] AddItemRequest req);

        [Get("/items/{userguid}/{lastid}")]
        Task<ApiResponse<GetItemsResult>> GetItems(string userguid, int lastid);

        [Get("/clearchat/{userguid}")]
        Task<ApiResponse<ClearChatResponse>> ClearChat(string userguid);
    }

}
