using System.Collections.Generic;
using System.Linq;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using DevNcore.UI.Foundation.Mvvm;

namespace Lol.Collection.Local.ViewModel
{
    public class ItemViewModel : ObservableObject
    {
        public RelayCommand<object> ButtonTest { get; set; }

        private bool _buttonUsed;
        private List<Items> _itemList;
        private string _searchText;

        #region ButtonUsed

        public bool ButtonUsed
        {
            get => _buttonUsed;
            set { _buttonUsed = value; OnPropertyChanged(); }
        }
        #endregion

        #region ItemList

        public List<Items> ItemList
        {
            get { return _itemList; }
            set { _itemList = value; OnPropertyChanged(); }
        }
        #endregion

        #region SearchText

        public string SearchText
        {
            get { return _searchText; }
            set { _searchText = value; OnPropertyChanged(); ItemTextChanged(value); }
        }
        
        #endregion

        #region Constructor

        public ItemViewModel()
        {
            ItemList = new ItemApi().GetItems();
            ButtonTest = new RelayCommand<object>(Test1, Test2);
        }
        #endregion

        #region ItemTextChanged
        private void ItemTextChanged(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                ItemList = new ItemApi().GetItems();
                return;
            }

            ItemList = new ItemApi().GetItems();
            var list = ItemList.Where(x => x.Name.Contains(value));
            ItemList = list.ToList();
        }
        #endregion

        //TODO: [Lucas] 추후 Button Event 작업
        private void Test1(object obj)
        {
            //int cnt = ItemLists.Count;

            //var item = new MyItemListModel
            //{
            //    Seq = cnt,
            //    Name = $"새로운 아이템 세트({cnt})",
            //    Champ = "모든 챔피언",
            //    CheckCommand = new RelayCommand<object>(Checked),
            //    MapType1 = ImgResource("Map", "Summoner's_rift"),
            //    MapType2 = ImgResource("Map", "Howling_Abyss"),
            //};

            //List<MyItemListModel> source = new();

            //foreach(var i in ItemLists)
            //{
            //    source.Add(i);
            //}

            //source.Add(item);

            //ItemLists = source;
        }

        private void Checked(object value)
        {
            ButtonUsed = true;
            var dd = ItemList.Where(x => x.IsChecked);
            //ButtonUsed = ItemLists.Where(x => x.IsChecked);
        }

        private bool Test2(object obj)
        {
            return true;
        }
    }
}
