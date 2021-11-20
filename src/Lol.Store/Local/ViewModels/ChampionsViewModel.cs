using Lol.Data.Enums;
using Lol.Data.Store;
using Lol.Foundation.Mvvm;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Store.Local.ViewModels
{
    public class ChampionsViewModel : ObservableObject
    {
        #region Variables

        private List<StoreDetails> _champMenus;
        private List<StoreChampSortings> _sorting;
        private List<StoreItems> _storeChamps;
        private List<FilterModel> _filters;

        private StoreDetails _currentChampMenu;
        private StoreChampSortings _currentSorting;
        private string _searchText;
        #endregion

        #region ChampMenus

        public List<StoreDetails> ChampMenus
        {
            get { return _champMenus; }
            set { _champMenus = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentChampMenu

        public StoreDetails CurrentChampMenu
        {
            get { return _currentChampMenu; }
            set { _currentChampMenu = value; OnPropertyChanged(); MenuChanged(value); }
        }
        #endregion

        #region Sorting

        public List<StoreChampSortings> Sorting
        {
            get { return _sorting; }
            set { _sorting = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentSorting

        public StoreChampSortings CurrentSorting
        {
            get { return _currentSorting; }
            set { _currentSorting = value; OnPropertyChanged(); }
        }
        #endregion

        #region StoreChamps

        public List<StoreItems> StoreChamps
        {
            get { return _storeChamps; }
            set { _storeChamps = value; OnPropertyChanged(); }
        }
        #endregion

        #region SearchText

        public string SearchText
        {
            get { return _searchText; }
            set { _searchText = value; OnPropertyChanged(); SearchTextChanged(value); }
        }
        #endregion

        #region Filters

        public List<FilterModel> Filters
        {
            get { return _filters; }
            set { _filters = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public ChampionsViewModel()
        {
            ChampMenus = new StoreApi().GetCategory();
            CurrentChampMenu = ChampMenus.First();
            StoreChamps = new StoreApi().GetChamps();
        }
        #endregion

        #region MenuChanged

        private void MenuChanged(StoreDetails value)
        {
            string id = value.Name == "BUNDLES" ? value.Name : "STANDARD";

            Filters = GetFilters(value.Name);
            Sorting = new StoreApi().GetSorting(id);
            CurrentSorting = Sorting.First();          
        }
        #endregion

        #region SearchTextChanged

        private void SearchTextChanged(string _)
        {
            if (CurrentChampMenu.Name == "CHAMPIONS")
            {
                //
            }
        }
        #endregion

        #region Temp data

        public static List<FilterModel> filters = new()
        {
            new FilterModel(ChampType.Assassin, "Assassin", true, true, false),
            new FilterModel(ChampType.Fighter, "Fighter", true, true, false),
            new FilterModel(ChampType.Mage, "Mage", true, true, false),
            new FilterModel(ChampType.Marksman, "Marksman", true, true, false),
            new FilterModel(ChampType.Support, "Support", true, true, false),
            new FilterModel(ChampType.Tanker, "Tank", true, true, false),
            new FilterModel(PackageType.StarterSet, "Starter Series", false, true, false),
            new FilterModel(PackageType.SeriesA, "Series 1", false, true, false),
            new FilterModel(PackageType.OnSale, "On Sale", true, true, false),
            new FilterModel(PackageType.Limited, "Limited Availability", false, false, true)
        };

        public static List<FilterModel> GetFilters(string name)
        {
            List<FilterModel> source = new();

            switch (name)
            {
                case "CHAMPIONS": source = filters.Where(x => x.IsChampionVisible).ToList(); break;
                case "ETERNALS": source = filters.Where(x => x.IsEternalVisible).ToList(); break;
                case "BUNDLES": source = filters.Where(x => x.IsBundleVisible).ToList(); break;
                default:
                    break;
            }

            return source;
        }
        #endregion
    }
}
