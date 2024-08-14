using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equin.ApplicationFramework
{
    public static class Messages
    {
        public const string CannotAddItem = "Cannot add an external item to the view. Use AddNew() or add to source list instead.";
        public const string CannotAddNewItem = "Cannot add a new item due to no object being provided in the AddingNew event and a lack of default public constructor.";
        public const string CannotAddWhenNewItemsListNull = "Cannot add a new item when NewItemsList is null.";
        public const string CannotClearView = "Cannot clear this view.";
        public const string CannotInsertItem = "Cannot insert an external item into this collection.";
        public const string CannotSetItem = "Cannot set an item in the view.";
        public const string IncludeDelegateCannotBeNull = "= includeDelegate cannot be null.";
        public const string InvalidListItemType = "Item in list is not of type {0}.";
        public const string InvalidSourceList = "Source list does not implement IList.";
        public const string ItemTypeIncorrect = "Item was not of type {0}.";
        public const string NoFilter = "(no filter)";
        public const string ObjectCannotBeNull = "Object cannot be null.";
        public const string PredicateFilter = "(predicate filter)";
        public const string PropertyNotFound = "Property {0} does not exist in type {1}.";
        public const string SourceListAlreadyAdded = "Source list already added to the view.";
        public const string SourceListNotFound = "Source list is not in the view.";
        public const string SourceListsNull = "SourceLists cannot be null.";
        public const string SyncAccessNotSupported = "Synchronized access to the view is not supported.";
    }
}
