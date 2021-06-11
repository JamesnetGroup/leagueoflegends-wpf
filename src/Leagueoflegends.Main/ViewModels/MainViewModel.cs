using Leagueoflegends.Data.Menu;
using Leagueoflegends.Home.General.ViewModels;
using Leagueoflegends.Home.General.Views;
using Leagueoflegends.LayoutSupport.Controls;
using Leagueoflegends.Main.Views;
using Leagueoflegends.Menus.ViewModels;
using Leagueoflegends.TitleBar.ViewModels;
using Leagueoflegends.Windowbase.Mvvm;
using Leagueoflegends.Windowbase.Riotcore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Leagueoflegends.Main.ViewModels
{
	public class MainViewModel : ObservableObject
	{
		private IRiotUIElement _currentUI;
		private List<SubMenuModel> _subMenus;
		private SubMenuModel _currentSubMenu;
		private Dictionary<int, IRiotUIElement> UIs { get; set; }

		public MainMenuViewModel MainMenu { get; }
		public TitleBarViewModel TitleBar { get; }

		#region CurrentUI

		public IRiotUIElement CurrentUI
		{
			get => _currentUI;
			set { _currentUI = value; OnPropertyChanged(); }
		}
		#endregion

		#region SubMenus

		public SubMenuModel CurrentSubMenu
		{
			get => _currentSubMenu;
			set { _currentSubMenu = value; OnPropertyChanged(); SubMenuChanged(value); }
		}


		public List<SubMenuModel> SubMenus
		{
			get { return _subMenus; }
			set { _subMenus = value; OnPropertyChanged(); }
		}

		#endregion

		#region Constructor

		public MainViewModel()
		{
			UIs = new();
			TitleBar = new(new RelayCommand<object>(TitlebarSelected));
			MainMenu = new(MenuSelected);
		}
		#endregion

		private void MenuSelected(MainMenuModel menu, List<SubMenuModel> subMenus)
		{
			SubMenus = subMenus;
			CurrentSubMenu = SubMenus.FirstOrDefault();
		}

		private void SubMenuChanged(SubMenuModel value)
		{
			if (value != null)
			{
				IRiotUIElement content = value.Seq switch
				{
					0 => new GeneralView().UseViewModel(new GeneralViewModel()),
					_ => new EmptyContent(),
				};

				if (!UIs.ContainsKey(value.Seq))
				{
					UIs.Add(value.Seq, content);
				}

				CurrentUI = UIs[value.Seq];
			}
		}

		private void TitlebarSelected(object obj)
		{
			switch (obj.ToString())
			{
				case "MIN": Window.GetWindow(View).WindowState = WindowState.Minimized; break;
				case "CLOSE": Environment.Exit(0); break;
			}
		}
	}
}