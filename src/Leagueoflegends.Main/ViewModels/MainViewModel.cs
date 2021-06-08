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
		public MenuBoxViewModel MenuBox { get; }
		public TitleBarViewModel TitleBar { get; }

		public MainViewModel()
		{
			MenuBox = new MenuBoxViewModel(new RelayCommand<MenuBoxModel>(MenuSelected));
			TitleBar = new TitleBarViewModel(new RelayCommand<object>(TitlebarButtonClick));
		}

		private void MenuSelected(MenuBoxModel menu)
		{
		}

		private void TitlebarButtonClick(object obj)
		{
			switch(obj.ToString())
			{
				case "MIN": Window.GetWindow(View).WindowState = WindowState.Minimized; break;
				case "CLOSE": Environment.Exit(0); break;
			}
		}
	}
}