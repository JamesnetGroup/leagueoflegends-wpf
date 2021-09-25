using Lol.Data.Collection;
using Lol.ExampleData.Collection;
using Lol.Foundation.Mvvm;
using System;
using System.Collections.Generic;

namespace Lol.Collection.Local.ViewModel
{
    public class ItemViewModel : ObservableObject
    {
        #region ItemLists

        public List<ItemListModel> ItemLists { get; set; }

        public RelayCommand<object> ButtonTest { get; set; }
        #endregion

        #region Constructor

        public ItemViewModel()
        {
            ItemLists = ExamItemList.GetItemList();
            ButtonTest = new RelayCommand<object>(Test1, Test2);
        }

        private void Test1(object obj)
        {
        }

        private bool Test2(object obj)
        {
            return true;
        }
        #endregion

    }
}
