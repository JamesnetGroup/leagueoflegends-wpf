using Leagueoflegends.Data.Menu;
using Leagueoflegends.Home.General.ViewModels;
using Leagueoflegends.Home.General.Views;
using Leagueoflegends.Main.Views;
using Leagueoflegends.Menus.ViewModels;
using Leagueoflegends.MyShop.ViewModels;
using Leagueoflegends.MyShop.Views;
using Leagueoflegends.TeamFight.ViewModels;
using Leagueoflegends.TeamFight.Views;
using Leagueoflegends.TitleBar.ViewModels;
using Leagueoflegends.Windowbase.Mvvm;
using Leagueoflegends.Windowbase.Riotcore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Leagueoflegends.Main.ViewModels
{
	public class MainViewModel : ObservableObject
	{
		private IRiotUIElement _currentUI;
		private List<SubMenuModel> _subMenus;
		private SubMenuModel _currentSubMenu;
		private MainMenuModel _mainMenu;
		private List<CommunityModel> _friends;
		private Dictionary<string, IRiotUIElement> UIs { get; set; }

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
			get => _subMenus;
			set { _subMenus = value; OnPropertyChanged(); }
		}

		#endregion

		#region Friends

		public List<CommunityModel> Friends
		{
			get => _friends;
			set { _friends = value; OnPropertyChanged(); }
		}

		public int TotalFriendsCount { get; set; }
		public int GeneralFriendsCount { get; set; }
		public int OfflineFriendsCount { get; set; }
		#endregion

		#region Constructor

		public MainViewModel()
		{
			UIs = new();
			TitleBar = new(new RelayCommand<object>(TitlebarSelected));
			MainMenu = new(MenuSelected);
			InitFriends();
		}
		#endregion

		#region MenuSelected

		private void MenuSelected(MainMenuModel menu, List<SubMenuModel> subMenus)
		{
			_mainMenu = menu;
			SubMenus = subMenus;
			CurrentSubMenu = SubMenus.FirstOrDefault();
		}
		#endregion

		#region SubMenuChanged

		private void SubMenuChanged(SubMenuModel value)
		{
			IRiotUIElement content;
			string key;

			if (value != null)
			{
				key = value.Name;
				content = value.Seq switch
				{
					0 => new GeneralView().UseViewModel(new GeneralViewModel()),
					_ => new EmptyContent()
				};
			}
			else
			{
				key = _mainMenu.Name;
				content = _mainMenu.Seq switch
				{
					1 => new TeamFightView().UseViewModel(new TeamFightViewModel()),
					6 => new MyShopView().UseViewModel(new MyShopViewModel()),
					_ => new EmptyContent()
				};
			}

			if (!UIs.ContainsKey(key))
			{
				UIs.Add(key, content);
			}

			CurrentUI = UIs[key];
		}
		#endregion

		#region TitlebarSelected

		private void TitlebarSelected(object obj)
		{
			switch (obj.ToString())
			{
				case "MIN": Window.GetWindow(View).WindowState = WindowState.Minimized; break;
				case "CLOSE": Environment.Exit(0); break;
			}
		}
		#endregion

		#region InitFriends

		private void InitFriends()
		{
			List<CommunityModel> friends = new()
			{
				new CommunityModel { IsUser = false, Name = "GENERAL" },
				new CommunityModel { IsUser = false, Name = "OFFLINE" }
			};

			friends[0].Children = new List<CommunityModel>();
			friends[1].Children = new List<CommunityModel>();

			friends[0].Children.Add(new CommunityModel { IsUser = true, Name = "elenakim", Status = "안녕", IsGeneral = true, MD5 = "/Leagueoflegends.Resources;component/Images/Square/0.png", Children = new List<CommunityModel>() });
			friends[0].Children.Add(new CommunityModel { IsUser = true, Name = "jameslee", Status = "굿굿", IsGeneral = true, MD5 = "/Leagueoflegends.Resources;component/Images/Square/1.png", Children = new List<CommunityModel>() });

			friends[1].Children.Add(new CommunityModel { IsUser = true, Name = "joolo", Status = "왈왈", IsGeneral = false, MD5 = "/Leagueoflegends.Resources;component/Images/Square/2.png", Children = new List<CommunityModel>() });
			friends[1].Children.Add(new CommunityModel { IsUser = true, Name = "CokePlay", Status = "콜라가 먹고싶다", IsGeneral = false, MD5 = "/Leagueoflegends.Resources;component/Images/Square/3.png", Children = new List<CommunityModel>() });
			friends[1].Children.Add(new CommunityModel { IsUser = true, Name = "권율장군", Status = "장군쓰", IsGeneral = false, MD5 = "/Leagueoflegends.Resources;component/Images/Square/4.png", Children = new List<CommunityModel>() });
			friends[1].Children.Add(new CommunityModel { IsUser = true, Name = "잠시만할게여", Status = "진짜로", IsGeneral = false, MD5 = "/Leagueoflegends.Resources;component/Images/Square/5.png", Children = new List<CommunityModel>() });
			friends[1].Children.Add(new CommunityModel { IsUser = true, Name = "주방행님들", Status = "배고퓨", IsGeneral = false, MD5 = "/Leagueoflegends.Resources;component/Images/Square/6.png", Children = new List<CommunityModel>() });
			friends[1].Children.Add(new CommunityModel { IsUser = true, Name = "펭수오리", Status = "펭펭", IsGeneral = false, MD5 = "/Leagueoflegends.Resources;component/Images/Square/7.png", Children = new List<CommunityModel>() });
			friends[1].Children.Add(new CommunityModel { IsUser = true, Name = "3초돌고래", Status = "끼룩끼룩", IsGeneral = false, MD5 = "/Leagueoflegends.Resources;component/Images/Square/8.png", Children = new List<CommunityModel>() });
			friends[1].Children.Add(new CommunityModel { IsUser = true, Name = "jongzzong", Status = "jongzzong", IsGeneral = false, MD5 = "/Leagueoflegends.Resources;component/Images/Square/9.png", Children = new List<CommunityModel>() });
			friends[1].Children.Add(new CommunityModel { IsUser = true, Name = "YJ2901", Status = "안녕", IsGeneral = false, MD5 = "/Leagueoflegends.Resources;component/Images/Square/10.png", Children = new List<CommunityModel>() });

			Friends = friends;
			GeneralFriendsCount = friends[0].Children.Count();
			OfflineFriendsCount = friends[1].Children.Count();
			TotalFriendsCount = GeneralFriendsCount + OfflineFriendsCount;
		}
		#endregion
	}
}