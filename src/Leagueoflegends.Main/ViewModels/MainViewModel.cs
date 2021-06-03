using Leagueoflegends.Data.Menu;
using Leagueoflegends.Menus.ViewModels;
using Leagueoflegends.Windowbase.Mvvm;

namespace Leagueoflegends.Main.ViewModels
{
	public class MainViewModel
	{
		public MenuBoxViewModel MenuBoxViewModel { get; }

		public MainViewModel()
		{
			RelayCommand<MenuBoxModel> command = new(MenuSelected);
			MenuBoxViewModel = new MenuBoxViewModel(command);
		}

		private void MenuSelected(MenuBoxModel menu)
		{
		}
	}
}