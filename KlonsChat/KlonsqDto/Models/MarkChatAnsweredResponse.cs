using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsChatDto.Models
{
    public enum EMarkChatAnsweredResult { None, Ok, BadRequest, NotAuthorized, UserNotFound }
    public  class MarkChatAnsweredResponse
    {
        public EMarkChatAnsweredResult Result { get; set; } = EMarkChatAnsweredResult.None;
    }
}
