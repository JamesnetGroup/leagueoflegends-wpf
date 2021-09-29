using System.Linq;
using System.Collections.Generic;
using Lol.Collection.Local.Model;
using Lol.ExampleData.Collection;
using Lol.Foundation.Mvvm;

namespace Lol.Collection.Local.ViewModel
{
    public class ItemViewModel : ObservableObject
    {
        #region ItemLists

        private List<MyItemListModel> _itemLists;

        public RelayCommand<object> ButtonTest { get; set; }
        #endregion

        private bool _buttonUsed;
        public bool ButtonUsed
        {
            get => _buttonUsed;
            set { _buttonUsed = value; OnPropertyChanged(); }
        }

        public List<MyItemListModel> ItemLists
        {
            get { return _itemLists; }
            set { _itemLists = value; OnPropertyChanged(); }
        }

        #region Constructor

        public ItemViewModel()
        {
            var item = ExamItemList.GetItemList();

            _itemLists = item.Select(x => new MyItemListModel(x, Checked)).ToList();
            ButtonTest = new RelayCommand<object>(Test1, Test2);
        }

        private static string ImgResource(string folder, string name)
        {
            return $"/Lol.Resources;component/Images/{folder}/{name}.png";
        }

        private void Test1(object obj)
        {
            int cnt = ItemLists.Count;

            var item = new MyItemListModel
            {
                Seq = cnt,
                Name = $"새로운 아이템 세트({cnt})",
                Champ = "모든 챔피언",
                CheckCommand = new RelayCommand<object>(Checked),
                MapType1 = ImgResource("Map", "Summoner's_rift"),
                MapType2 = ImgResource("Map", "Howling_Abyss"),
            };

            List<MyItemListModel> source = new();

            foreach(var i in ItemLists)
            {
                source.Add(i);
            }

            source.Add(item);

            ItemLists = source;
        }

        private void Checked(object value)
        {
            ButtonUsed = ItemLists.Where(x => x.IsChecked).Any();
        }

        private bool Test2(object obj)
        {
            return true;
        }
        #endregion

    }
}
