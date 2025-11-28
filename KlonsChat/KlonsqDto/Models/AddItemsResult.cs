using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsChatDto.Models
{
    public enum EAddItemsResult { Ok, UserCreated, BadRequest, TooLong, NotAuthorized }
    public class AddItemsResult
    {
        public EAddItemsResult Result { get; set; }
        public ItemDto Item { get; set; }
    }

}
