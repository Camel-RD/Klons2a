using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsChatDto.Models
{
    public enum EClearChatResult { None, Ok, BadRequest, UserNotFound}
    public class ClearChatResponse
    {
        public EClearChatResult Result { get; set; } = EClearChatResult.None;
    }
}
