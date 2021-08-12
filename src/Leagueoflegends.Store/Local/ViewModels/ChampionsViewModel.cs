using Leagueoflegends.Data.Store;
using Leagueoflegends.ExampleData.Store;
using Leagueoflegends.Foundation.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace Leagueoflegends.Store.Local.ViewModels
{
	public class ChampionsViewModel : ObservableObject
    {
        private List<StoreMenuModel> _champMenus;
        private List<SortingModel> _sorting;

        private StoreMenuModel _currentChampMenu;
        private SortingModel _currentSorting;
        private string _searchText;

        #region ChampMenus

        public List<StoreMenuModel> ChampMenus
        {
            get { return _champMenus; }
            set { _champMenus = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentChampMenu

        public StoreMenuModel CurrentChampMenu
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

        #region Constructor

        public ChampionsViewModel()
		{
            ChampMenus = ExamStore.GetCategory();
            CurrentChampMenu = ChampMenus.First();
        }
		#endregion

		#region MenuChanged

        private void MenuChanged(StoreMenuModel value)
		{
            Sorting = ExamStore.GetSorting(value.Name);
            CurrentSorting = Sorting.First();
		}
        #endregion

        #region SearchTextChanged

        private void SearchTextChanged(string value)
        {
            if (CurrentChampMenu.Name == "Champions")
            {
                //
            }
        }
		#endregion

	}
}
