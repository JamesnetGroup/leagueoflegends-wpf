using Leagueoflegends.Data.Menu;
using Leagueoflegends.Windowbase.Mvvm;
using System.Collections.Generic;

namespace Leagueoflegends.Menus.ViewModels
{
	public class MainMenuViewModel : ObservableObject
	{
		public List<MenuBoxModel> Menus { get; }

		public MainMenuViewModel(RelayCommand<MenuBoxModel> menuCommand)
		{
			Menus = GetMenus();
			Menus.ForEach(x => x.MenuSelectCommand = menuCommand);
		}

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