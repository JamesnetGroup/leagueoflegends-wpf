using Leagueoflegends.Data.Menu;
using Leagueoflegends.LayoutSupport.Controls;
using Leagueoflegends.Menus.ViewModels;
using Leagueoflegends.TitleBar.ViewModels;
using Leagueoflegends.Windowbase.Mvvm;
using System;
using System.Windows;

namespace Leagueoflegends.Main.ViewModels
{
	public class MainViewModel : ObservableObject
	{
		public MainMenuViewModel MainMenu { get; }
		public TitleBarViewModel TitleBar { get; }

		public MainViewModel()
		{
			MainMenu = new MainMenuViewModel(new RelayCommand<MenuBoxModel>(MenuSelected));
			TitleBar = new TitleBarViewModel(new RelayCommand<object>(TitlebarSelected));
		}

		private void MenuSelected(MenuBoxModel menu)
		{
		}

		private void TitlebarSelected(object obj)
		{
			switch(obj.ToString())
			{
				case "MIN": Window.GetWindow(View).WindowState = WindowState.Minimized; break;
				case "CLOSE": Environment.Exit(0); break;
			}
		}
	}
}