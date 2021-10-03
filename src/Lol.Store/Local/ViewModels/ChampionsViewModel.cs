using Lol.Data.Store;
using Lol.ExampleData.Store;
using Lol.Foundation.Mvvm;
using Lol.YamlDatabase.Controller;
using Lol.YamlDatabase.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Store.Local.ViewModels
{
    public class ChampionsViewModel : ObservableObject
    {
        #region Variables

        private List<StoreChampTypes> _champMenus;
        private List<SortingModel> _sorting;
        private List<FilterModel> _filters;

        private StoreChampTypes _currentChampMenu;
        private SortingModel _currentSorting;
        private string _searchText;
        #endregion

        #region ChampMenus

        public List<StoreChampTypes> ChampMenus
        {
            get { return _champMenus; }
            set { _champMenus = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentChampMenu

        public StoreChampTypes CurrentChampMenu
        {
            get { return _currentChampMenu; }
            set { _currentChampMenu = value; OnPropertyChanged(); MenuChanged(value); }
        }
        #endregion

        #region Sorting

        public List<SortingModel> Sorting
        {
            get { return _sorting; }
            set { _sorting = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentSorting

        public SortingModel CurrentSorting
        {
            get { return _currentSorting; }
            set { _currentSorting = value; OnPropertyChanged(); }
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
            //CurrentChampMenu = ChampMenus.First();
        }
        #endregion

        #region MenuChanged

        private void MenuChanged(StoreChampTypes value)
        {
            Filters = ExamStore.GetFilters(value.Name);
            Sorting = ExamStore.GetSorting(value.Name);
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

    }
}
