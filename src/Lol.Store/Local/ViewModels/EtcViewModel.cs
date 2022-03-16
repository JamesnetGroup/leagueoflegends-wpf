using DevNcore.UI.Foundation.Mvvm;
using Lol.Data.Enums;
using Lol.Data.Store;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Store.Local.ViewModels
{
    public class EtcViewModel : ObservableObject
    {
        #region Variables

        private List<StoreDetails> _etcMenus;
        private StoreDetails _currentEtcMenu;

        private List<StoreChampSortings> _sorting;
        private StoreChampSortings _currentSorting;

        private List<FilterModel> _filters;

        private List<StoreItems> _storeEtcItems;
        #endregion

        #region EtcMenus

        public List<StoreDetails> EtcMenus
        {
            get { return _etcMenus; }
            set { _etcMenus = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentEtcMenu

        public StoreDetails CurrentEtcMenu
        {
            get { return _currentEtcMenu; }
            set { _currentEtcMenu = value; OnPropertyChanged(); MenuChanged(value); }
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

        #region StoreEtcItems

        public List<StoreItems> StoreEtcItems
        {
            get { return _storeEtcItems; }
            set { _storeEtcItems = value; OnPropertyChanged(); }
        }
        #endregion


        #region Constructor

        public EtcViewModel()
        {
            StoreApi api = new StoreApi();
            EtcMenus = api.GetCategory(5);
            CurrentEtcMenu = EtcMenus.First();
            StoreEtcItems = api.GetEtcItems();
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
            new FilterModel(PackageType.Limited, "한정 판매", false, true, true),
            new FilterModel(PackageType.Limited, "할인중", true, false, false),
        };

        public static List<FilterModel> GetFilters(string name)
        {
            List<FilterModel> source = new();

            switch (name)
            {
                case "감정표현": source = filters.Where(x => x.IsChampionVisible).ToList(); break;
                case "와드 스킨": source = filters.Where(x => x.IsEternalVisible).ToList(); break;
                case "세트": source = filters.Where(x => x.IsBundleVisible).ToList(); break;
                default:
                    break;
            }

            return source;
        }
        #endregion
    }


}
