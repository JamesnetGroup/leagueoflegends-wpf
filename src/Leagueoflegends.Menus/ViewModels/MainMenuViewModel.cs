using Leagueoflegends.Data.Menu;
using Leagueoflegends.Windowbase.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Leagueoflegends.Menus.ViewModels
{
	public class MainMenuViewModel : ObservableObject
	{
		#region Menus

		private MenuBoxModel _currentMenu;
		public MenuBoxModel CurrentMenu
		{
			get => _currentMenu;
			set { _currentMenu = value; OnPropertyChanged(); }
		}

		public List<MenuBoxModel> Menus { get; }

		#endregion

		#region Constructor

		public MainMenuViewModel(Action<MenuBoxModel> menuCommand)
		{
			Menus = GetMenus();
			CurrentMenu = Menus.First();
			Menus.ForEach(x => x.MenuSelectCommand = new RelayCommand<MenuBoxModel>(menuCommand));
		}
        #endregion

        #region GetMenus

        private List<MenuBoxModel> GetMenus()
		{
			List<MenuBoxModel> source = new()
			{
				new MenuBoxModel(0, "HOME", "TEXT"),
				new MenuBoxModel(1, "TFT", "TEXT"),
				new MenuBoxModel(2, "CLASH", "TEXT"),
				new MenuBoxModel(3, "My Info", "ICON"),
				new MenuBoxModel(4, "Collection", "ICON"),
				new MenuBoxModel(5, "Production", "ICON"),
				new MenuBoxModel(6, "My Shop", "ICON"),
				new MenuBoxModel(7, "Store", "ICON")
			};
			return source;
		}
		#endregion
	}
}