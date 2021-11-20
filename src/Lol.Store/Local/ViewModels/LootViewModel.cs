using Lol.Data.Enums;
using Lol.Data.Store;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Store.Local.ViewModels
{
    public class LootViewModel : ObservableObject
    {
        #region Variables

        private List<StoreChampSortings> _sorting;
        private StoreChampSortings _currentSorting;

        private List<StoreItems> _storeLoots;
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

        #region StoreLoots

        public List<StoreItems> StoreLoots
        {
            get { return _storeLoots; }
            set { _storeLoots = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public LootViewModel()
        {
            StoreApi api = new StoreApi();
            StoreLoots = api.GetLoots();

            Sorting = new StoreApi().GetSorting("BUNDLES");
            CurrentSorting = Sorting.First();
        }
        #endregion
    }


}
