using Lol.Data.Collection;
using Lol.ExampleData.Collection;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;

namespace Lol.Collection.Local.ViewModel
{
    public class ItemViewModel : ObservableObject
    {
        #region ItemLists

        private List<ItemListModel> _itemLists;

        public RelayCommand<object> ButtonTest { get; set; }
        #endregion

        public List<ItemListModel> ItemLists
        {
            get { return _itemLists; }
            set { _itemLists = value; OnPropertyChanged(); }
        }

        #region Constructor

        public ItemViewModel()
        {
            ItemLists = ExamItemList.GetItemList();
            ButtonTest = new RelayCommand<object>(Test1, Test2);
        }

        private static string ImgResource(string folder, string name)
        {
            return $"/Lol.Resources;component/Images/{folder}/{name}.png";
        }

        private void Test1(object obj)
        {
            int cnt = ItemLists.Count;

            var item = new ItemListModel
            {
                Seq = cnt,
                Name = $"새로운 아이템 세트({cnt})",
                Champ = "모든 챔피언",
                MapType1 = ImgResource("Map", "Summoner's_rift"),
                MapType2 = ImgResource("Map", "Howling_Abyss"),
            };

            List<ItemListModel> source = new List<ItemListModel>();

            foreach(var i in ItemLists)
            {
                source.Add(i);
            }

            source.Add(item);

            ItemLists = source;
        }

        private bool Test2(object obj)
        {
            return true;
        }
        #endregion

    }
}
