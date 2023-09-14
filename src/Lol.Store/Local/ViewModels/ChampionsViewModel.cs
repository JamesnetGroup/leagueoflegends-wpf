using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using System.Collections.Generic;
using System.Linq;
using Lol.Data.Store;
using Lol.Data.Enums;
using Jamesnet.Wpf.Mvvm;

namespace Lol.Store.Local.ViewModels
{
    public class StoreChampionsViewModel : ObservableBase
    {
        private List<StoreDetails> _champMenus;
        private List<StoreChampSortings> _sorting;
        private List<StoreItems> _storeChamps;
        private List<FilterModel> _filters;

        private StoreDetails _currentChampMenu;
        private StoreChampSortings _currentSorting;
        private string _searchText;

        public List<StoreDetails> ChampMenus
        {
            get { return _champMenus; }
            set { _champMenus = value; OnPropertyChanged(); }
        }

        public StoreDetails CurrentChampMenu
        {
            get { return _currentChampMenu; }
            set { _currentChampMenu = value; OnPropertyChanged(); MenuChanged(value); }
        }

        public List<StoreChampSortings> Sorting
        {
            get { return _sorting; }
            set { _sorting = value; OnPropertyChanged(); }
        }

        public StoreChampSortings CurrentSorting
        {
            get { return _currentSorting; }
            set { _currentSorting = value; OnPropertyChanged(); }
        }

        public List<StoreItems> StoreChamps
        {
            get { return _storeChamps; }
            set { _storeChamps = value; OnPropertyChanged(); }
        }

        public string SearchText
        {
            get { return _searchText; }
            set { _searchText = value; OnPropertyChanged(); SearchTextChanged(value); }
        }

        public List<FilterModel> Filters
        {
            get { return _filters; }
            set { _filters = value; OnPropertyChanged(); }
        }

        public StoreChampionsViewModel()
        {
            ChampMenus = new StoreApi().GetCategory(1);
            CurrentChampMenu = ChampMenus.First();
            StoreChamps = new StoreApi().GetChamps();
        }

        private void MenuChanged(StoreDetails value)
        {
            string id = value.Name == "BUNDLES" ? value.Name : "STANDARD";

            Filters = GetFilters(value.Name);
            Sorting = new StoreApi().GetSorting(id);
            CurrentSorting = Sorting.First();          
        }

        private void SearchTextChanged(string _)
        {
            if (CurrentChampMenu.Name == "CHAMPIONS")
            {
                //
            }
        }

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
    }
}
