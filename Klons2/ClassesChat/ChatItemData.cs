using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsF.ClassesChat
{
    public enum EChatItemType { Question, Answer }
    public class ChatItemData
    {
        public int? Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Content { get; set; }
        public EChatItemType Type { get; set; } = EChatItemType.Question;

        public ChatItemData Clone()
        {
            var ret = new ChatItemData()
            {
                Id = Id,
                Content = Content,
                DateCreated = DateCreated,
                Type = Type
            };
            return ret;
        }

        public bool Equals(ChatItemData item)
        {
            return
                Id == Id &&
                Content == Content &&
                DateCreated == DateCreated &&
                Type == Type;
        }

    }


}
