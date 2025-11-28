using KlonsChatDto.Models;
using KlonsLIB.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KlonsF.ClassesChat
{
    public enum EChatCheckInbox { Never, OnAppStart, After1Hour, After5Hour, After1Day }
    public class ChatData
    {
        public string UserGuid;
        public List<ChatItemData> ChatItems = new();
        public DateTime LastChecked;
        public EChatCheckInbox ChatCheckInbox = EChatCheckInbox.Never;

        [XmlIgnore]
        public ChatData NotModified;

        public static ChatItemData Map(ItemDto item)
        {
            var ret = new ChatItemData()
            {
                Id = item.Id,
                Content = item.Content,
                DateCreated = item.DateCreated,
                Type = item.Type == EItemDtoType.Answer ? EChatItemType.Answer : EChatItemType.Question
            };
            return ret;
        }
        public static List<ChatItemData> Map(List<ItemDto> items)
        {
            var ret = items.Select(x => Map(x)).ToList();
            return ret;
        }

        public List<ChatItemData> Add(List<ItemDto> items)
        {
            var ret = Map(items);
            foreach (var item in ret)
            {
                ChatItems.Add(item);
            }
            return ret;
        }

        public ChatData Clone()
        {
            var ret = new ChatData()
            {
                UserGuid = UserGuid,
                ChatItems = ChatItems.Select(x => x.Clone()).ToList(),
                LastChecked = LastChecked,
                ChatCheckInbox = ChatCheckInbox
            };
            return ret;
        }

        public bool Equals(ChatData chat)
        {
            if (UserGuid != chat.UserGuid) return false;
            if (LastChecked != chat.LastChecked) return false;
            if (ChatCheckInbox != chat.ChatCheckInbox) return false;
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

        public static ChatData LoadChat(string filename)
        {
            var settings = Utils.LoadDataFromXML<ChatData>(filename);
            if (settings == null)
                settings = new ChatData();
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



}
