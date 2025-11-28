using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsChatDb.Models
{
    public enum EItemType { QuestionNew, QuestionAnswered, Answer }

    public class Item
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public string Content { get; set; }
        public EItemType Type { get; set; } = EItemType.QuestionNew;
        public bool IsDeleted { get; set; } = false;
        public User User { get; set; }
    }
}
