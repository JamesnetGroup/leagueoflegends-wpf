using Leagueoflegends.Data.Store;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Store.Local.Work;
using System.Collections.Generic;
using System.Linq;

namespace Leagueoflegends.Store.Local.ViewModels
{
	public class ChampionsViewModel : ObservableObject
    {
        private List<StoreMenuModel> _champMenus;
        private StoreMenuModel _currentChampMenu;
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
            ChampMenus = new MenuWork().Menus;
            CurrentChampMenu = ChampMenus.First();
        }
		#endregion

		#region MenuChanged

        private void MenuChanged(StoreMenuModel value)
		{
            //
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
