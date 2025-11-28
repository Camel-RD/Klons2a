using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsChatDto.Models
{
    public enum EGetUpdatedChatsResult { None, Ok, BadRequest, NotAuthorized }
    public class GetUpdatedChatsResult
    {
        public EGetUpdatedChatsResult Result { get; set; }
        public List<UpdatedChatData> UpdatedChatList { get; set; }
    }

    public class UpdatedChatData
    {
        public string UserGuid { get; set; }
        public int NewItemCount { get; set; }
    }
}
