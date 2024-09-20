using Jamesnet.Wpf.Mvvm;
using Lol.Data.Enums;
using Lol.Data.Store;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Store.Local.ViewModels
{
    public class StoreSkinViewModel : ObservableBase
    {
        private List<StoreDetails> _skinMenus;
        private StoreDetails _currentSkinMenu;

        private List<StoreChampSortings> _sorting;
        private StoreChampSortings _currentSorting;

        private List<FilterModel> _filters;

        private List<StoreItems> _storeSkins;

        public List<StoreDetails> SkinMenus
        {
            get { return _skinMenus; }
            set { _skinMenus = value; OnPropertyChanged(); }
        }

        public StoreDetails CurrentSkinMenu
        {
            get { return _currentSkinMenu; }
            set { _currentSkinMenu = value; OnPropertyChanged(); MenuChanged(value); }
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

        public List<FilterModel> Filters
        {
            get { return _filters; }
            set { _filters = value; OnPropertyChanged(); }
        }

        public List<StoreItems> StoreSkins
        {
            get { return _storeSkins; }
            set { _storeSkins = value; OnPropertyChanged(); }
        }

        public StoreSkinViewModel()
        {
            StoreApi api = new StoreApi();
            SkinMenus = api.GetCategory(2);
            CurrentSkinMenu = SkinMenus.First();
            StoreSkins = api.GetSkins();
        }

        private void MenuChanged(StoreDetails value)
        {
            string id = value.Name == "BUNDLES" ? value.Name : "STANDARD";

            Filters = GetFilters(value.Name);

            Sorting = new StoreApi().GetSorting(id);
            CurrentSorting = Sorting.First();
        }

        public static List<FilterModel> filters = new()
        {
            new FilterModel(PackageType.Limited, "미보유 챔피언 숨기기", true, true, false),
            new FilterModel(PackageType.Limited, "한정 판매", true, false, true),
            new FilterModel(PackageType.Limited, "전설급 상품", true, false, false),
            new FilterModel(PackageType.Limited, "초월급 상품", true, false, false),
            new FilterModel(PackageType.Limited, "할인중", true, false, false),
            new FilterModel(PackageType.Limited, "보유 중인 스킨", false, true, false),
            new FilterModel(PackageType.Limited, "파랑 정수로 구매 가능", false, true, false),
        };

        public static List<FilterModel> GetFilters(string name)
        {
            List<FilterModel> source = new();

            switch (name)
            {
                case "스킨": source = filters.Where(x => x.IsChampionVisible).ToList(); break;
                case "크로마": source = filters.Where(x => x.IsEternalVisible).ToList(); break;
                case "세트": source = filters.Where(x => x.IsBundleVisible).ToList(); break;
                default:
                    break;
            }

            return source;
        }
    }
}
