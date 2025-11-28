using KlonsChatDb.Models;
using KlonsChatDto.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KlonsChatApiServer.Services
{
    public static class ItemMapper
    {
        public static ItemDto Map(Item item)
        {
            var ret = new ItemDto()
            {
                Id = item.Id,
                UserId = item.UserId,
                UserGUID = item.User.Guid,
                Content = item.Content,
                DateCreated = item.DateCreated,
                Type = Map(item.Type)
            };
            return ret;
        }

        public static Item Map(ItemDto item)
        {
            var ret = new Item()
            {
                Id = item.Id.Value,
                UserId = item.UserId.Value,
                Content = item.Content,
                DateCreated = item.DateCreated.Value,
                Type = Map(item.Type),
            };
            return ret;
        }

        public static List<ItemDto> Map(List<Item> items) =>
            items.Select(x => Map(x)).ToList();

        public static EItemDtoType Map(EItemType tp)
        {
            return tp switch
            {
                EItemType.Answer => EItemDtoType.Answer,
                EItemType.QuestionNew => EItemDtoType.QuestionNew,
                EItemType.QuestionAnswered => EItemDtoType.QuestionAnswered,
                _ => throw new NotImplementedException(),
            };
        }

        public static EItemType Map(EItemDtoType tp)
        {
            return tp switch
            {
                EItemDtoType.Answer => EItemType.Answer,
                EItemDtoType.QuestionNew => EItemType.QuestionNew,
                EItemDtoType.QuestionAnswered => EItemType.QuestionAnswered,
                EItemDtoType.None => throw new InvalidOperationException("Bad item type"),
                _ => throw new NotImplementedException(),
            };
        }

        public static EItemType Map(EAddItemType tp) =>
            tp == EAddItemType.Answer ? EItemType.Answer : EItemType.QuestionNew;


    }
}
