using DevNcore.UI.Foundation.Mvvm;
using Lol.Data.Enums;
using Lol.Data.Store;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Store.Local.ViewModels
{
    public class TFTViewModel : ObservableObject
    {
        #region Variables

        private List<StoreDetails> _tftMenus;
        private StoreDetails _currentTFTMenu;

        private List<StoreChampSortings> _sorting;
        private StoreChampSortings _currentSorting;

        private List<FilterModel> _filters;

        private List<StoreItems> _storeTFTs;
        #endregion

        #region TFTMenus

        public List<StoreDetails> TFTMenus
        {
            get { return _tftMenus; }
            set { _tftMenus = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentTFTMenu

        public StoreDetails CurrentTFTMenu
        {
            get { return _currentTFTMenu; }
            set { _currentTFTMenu = value; OnPropertyChanged(); MenuChanged(value); }
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

        #region Filters

        public List<FilterModel> Filters
        {
            get { return _filters; }
            set { _filters = value; OnPropertyChanged(); }
        }
        #endregion

        #region StoreTFTs

        public List<StoreItems> StoreTFTs
        {
            get { return _storeTFTs; }
            set { _storeTFTs = value; OnPropertyChanged(); }
        }
        #endregion


        #region Constructor

        public TFTViewModel()
        {
            StoreApi api = new StoreApi();
            TFTMenus = api.GetCategory(3);
            CurrentTFTMenu = TFTMenus.First();
            StoreTFTs = api.GetTFTs();
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

        #region Temp data

        public static List<FilterModel> filters = new()
        {
            new FilterModel(PackageType.Limited, "이벤트 패스", true, false, false),
            new FilterModel(PackageType.Limited, "알", true, false, false),
            new FilterModel(PackageType.Limited, "전략가", true, false, false),
        };

        public static List<FilterModel> GetFilters(string name)
        {
            List<FilterModel> source = new();

            switch (name)
            {
                case "전략가": source = filters.Where(x => x.IsChampionVisible).ToList(); break;
                case "결투장 스킨": source = filters.Where(x => x.IsEternalVisible).ToList(); break;
                case "별 파편": source = filters.Where(x => x.IsBundleVisible).ToList(); break;
                default:
                    break;
            }

            return source;
        }
        #endregion
    }


}
