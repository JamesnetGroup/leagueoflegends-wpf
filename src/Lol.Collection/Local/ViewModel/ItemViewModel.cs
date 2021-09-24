using Lol.Data.Collection;
using Lol.ExampleData.Collection;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;

namespace Lol.Collection.Local.ViewModel
{
    public class ItemViewModel : ObservableObject
    {
        #region ItemLists

        public List<ItemListModel> ItemLists { get; set; }
        #endregion

        #region Constructor

        public ItemViewModel()
        {
            ItemLists = ExamItemList.GetItemList();
        }
        #endregion

    }
}
