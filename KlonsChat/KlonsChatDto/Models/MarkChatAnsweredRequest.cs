using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsChatDto.Models
{
    public class MarkChatAnsweredRequest
    {
        public string UserGuid { get; set; }
        public string SupportGuid { get; set; }
    }
}
