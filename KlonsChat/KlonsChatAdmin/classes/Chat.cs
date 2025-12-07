using KlonsChatDto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KlonsChatAdmin.classes
{
    public class Chat
    {
        public string UserGuid;
        public List<ChatItem> ChatItems = new();

        [XmlIgnore]
        public Chat NotModified;

        public static List<ChatItem> Map(List<ItemDto> items)
        {
            var ret = new List<ChatItem>();
            foreach (var item in items)
            {
                var new_item = new ChatItem()
                {
                    Id = item.Id,
                    Content = item.Content,
                    DateCreated = item.DateCreated,
                    Type = item.Type == EItemDtoType.Answer ? EChatItemType.Answer : EChatItemType.Question
                };
                ret.Add(new_item);
            }
            return ret;
        }

        public List<ChatItem> Add(List<ItemDto> items)
        {
            var ret = Map(items);
            foreach (var item in ret)
            {
                ChatItems.Add(item);
            }
            return ret;
        }

        public Chat Clone()
        {
            var ret = new Chat()
            {
                UserGuid = UserGuid,
                ChatItems = ChatItems.Select(x => x.Clone()).ToList()
            };
            return ret;
        }

        public bool Equals(Chat chat)
        {
            if (UserGuid != chat.UserGuid) return false;
            if (ChatItems == null && chat.ChatItems != null) return false;
            if (ChatItems != null && chat.ChatItems == null) return false;
            if (ChatItems == null && chat.ChatItems == null) return true;
            if (ChatItems.Count != chat.ChatItems.Count) return false;
            for (int i = 0; i < ChatItems.Count; i++)
                if (!ChatItems[i].Equals(chat.ChatItems[i]))
                    return false;
            return true;
        }

        public bool HasChangesSettings()
        {
            if (NotModified == null) return true;
            var ret = !this.Equals(NotModified);
            return ret;
        }

        public static Chat LoadChat(string filename)
        {
            var settings = Utils.LoadDataFromXML<Chat>(filename);
            if (settings == null)
                settings = new Chat();
            settings.NotModified = settings.Clone();
            return settings;
        }

        public bool SaveChat(string filename)
        {
            if (!HasChangesSettings()) return true;
            bool rt = Utils.SaveDataToXML(this, filename);
            if (!rt) return false;
            NotModified = this.Clone();
            return true;
        }

    }

    public enum EChatItemType { Question, Answer }
    public class ChatItem
    {
        public int? Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Content { get; set; }
        public EChatItemType Type { get; set; } = EChatItemType.Question;

        public ChatItem Clone()
        {
            var ret = new ChatItem()
            {
                Id = Id,
                Content = Content,
                DateCreated = DateCreated,
                Type = Type
            };
            return ret;
        }

        public bool Equals(ChatItem item)
        {
            return 
                Id == Id &&
                Content == Content &&
                DateCreated == DateCreated &&
                Type == Type;
        }

    }


}
