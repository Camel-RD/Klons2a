using System;
using System.Runtime.Serialization;

namespace KlonsChatDto.Models
{

    public enum EItemDtoType { None, QuestionNew, QuestionAnswered, Answer }
    public enum EAddItemType { None, Question, Answer }

    public class ItemDto
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public string UserGUID { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Content { get; set; }
        public EItemDtoType Type { get; set; } = EItemDtoType.QuestionNew;
    }
}