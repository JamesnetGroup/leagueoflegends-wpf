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

		private MainMenuModel _currentMenu;
		public MainMenuModel CurrentMenu
		{
			get => _currentMenu;
			set { _currentMenu = value; OnPropertyChanged(); }
		}

		public List<MainMenuModel> Menus { get; }

		#endregion

		#region SubMenus

		private SubMenuModel _currentSubMenu;
		public SubMenuModel CurrentSubMenu
		{
			get => _currentSubMenu;
			set { _currentSubMenu = value; OnPropertyChanged(); }
		}

		public List<SubMenuModel> SubMenus { get; }

		#endregion

		#region Constructor

		public MainMenuViewModel(Action<MainMenuModel> menuCommand)
		{
			Menus = GetMenus();
			CurrentMenu = Menus.First();
			Menus.ForEach(x => x.MenuSelectCommand = new RelayCommand<MainMenuModel>(menuCommand));

			SubMenus = GetSubMenus();
			CurrentSubMenu = SubMenus.FirstOrDefault(x => x.MainSeq == CurrentMenu.Seq);
		}
		#endregion

		#region GetMenus

		private List<MainMenuModel> GetMenus()
		{
			List<MainMenuModel> source = new()
			{
				new MainMenuModel(0, "HOME", "TEXT"),
				new MainMenuModel(1, "TFT", "TEXT"),
				new MainMenuModel(2, "CLASH", "TEXT"),
				new MainMenuModel(3, "My Info", "ICON"),
				new MainMenuModel(4, "Collection", "ICON"),
				new MainMenuModel(5, "Production", "ICON"),
				new MainMenuModel(6, "My Shop", "ICON"),
				new MainMenuModel(7, "Store", "ICON")
			};
			return source;
		}
		#endregion

		#region GetSubMenus

		private List<SubMenuModel> GetSubMenus()
		{
			List<SubMenuModel> source = new()
			{
				new SubMenuModel(0, 0, "OVERVIEW"),
				new SubMenuModel(1, 0, "PRESEASON"),
				new SubMenuModel(2, 0, "PATCH NOTES"),

				new SubMenuModel(3, 4, "CHAMPIONS"),
				new SubMenuModel(4, 4, "SKINS"),
				new SubMenuModel(5, 4, "EMOTES"),
				new SubMenuModel(6, 4, "RUNES"),
				new SubMenuModel(7, 4, "SPELLS"),
				new SubMenuModel(8, 4, "ITEMS"),
				new SubMenuModel(9, 4, "ICONS"),
				new SubMenuModel(10, 4, "WARDS"),
				new SubMenuModel(11, 4, "CHROMAS"),

				new SubMenuModel(12, 7, "홈으로"),
				new SubMenuModel(13, 7, "챔피언"),
				new SubMenuModel(14, 7, "스킨"),
				new SubMenuModel(15, 7, "전략적 팀 전투"),
				new SubMenuModel(16, 7, "마법공학 제작"),
				new SubMenuModel(17, 7, "기타"),
			};
			return source;
		}
		#endregion
	}
}