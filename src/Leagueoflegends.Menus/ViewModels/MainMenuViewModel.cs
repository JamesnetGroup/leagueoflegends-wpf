using Leagueoflegends.Data.Menu;
using Leagueoflegends.Windowbase.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace Leagueoflegends.Menus.ViewModels
{
	public class MainMenuViewModel : ObservableObject
	{
		#region Menus

		private List<MenuBoxModel> _menus;
		public List<MenuBoxModel> Menus
		{
            get { return _menus; }
            set { _menus = value; OnPropertyChanged(); }
		}

		private MenuBoxModel _currentMenu;
		public MenuBoxModel CurrentMenu
		{
			get { return _currentMenu; }
			set { _currentMenu = value; OnPropertyChanged(); }
		}
        #endregion

        #region Constructor

        public MainMenuViewModel(RelayCommand<MenuBoxModel> menuCommand)
		{
			Menus = GetMenus();
			Menus.ForEach(x => x.MenuSelectCommand = menuCommand);
			CurrentMenu = Menus.First();
		}
        #endregion

        #region GetMenus

        private List<MenuBoxModel> GetMenus()
		{
			List<MenuBoxModel> source = new()
			{
				new MenuBoxModel("HOME"),
				new MenuBoxModel("TFT"),
				new MenuBoxModel("CLASH")
			};
			return source;
		}
		#endregion
	}
}