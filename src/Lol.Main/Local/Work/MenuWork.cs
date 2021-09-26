using Lol.Data.Main;
using Lol.Foundation.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Main.Local.Work
{
    public class MenuWork : ObservableObject
    {
        private readonly Action<MainMenuModel, List<SubMenuModel>> _menuCommand;

        #region Menus

        private MainMenuModel _currentMenu;
        public MainMenuModel CurrentMenu
        {
            get => _currentMenu;
            set { _currentMenu = value; OnPropertyChanged(); }
        }

        public List<MainMenuModel> Menus { get; }

        #endregion

        public List<SubMenuModel> TotalSubMenus { get; }

        #region Constructor

        public MenuWork(Action<MainMenuModel, List<SubMenuModel>> menuCommand)
        {
            _menuCommand = menuCommand;

            Menus = GetMenus();
            Menus.ForEach(x => x.MenuSelectCommand = new RelayCommand<MainMenuModel>(MenuChanged));
            TotalSubMenus = GetSubMenus();

            CurrentMenu = Menus.First();
            MenuChanged(CurrentMenu);
        }

        internal void MenuChanged(MainMenuModel obj)
        {
            List<SubMenuModel> subMenus = TotalSubMenus.Where(x => x.MainSeq == obj.Seq).ToList();
            _menuCommand.Invoke(obj, subMenus);
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
                new MainMenuModel(3, "Profile", "ICON"),
                new MainMenuModel(4, "Collection", "ICON"),
                new MainMenuModel(5, "Loot", "ICON"),
                new MainMenuModel(6, "My Shop", "ICON"),
                new MainMenuModel(7, "Store", "ICON"),
                new MainMenuModel(8, "GAME", "TEXT")
            };
            return source;
        }
        #endregion

        #region GetSubMenus

        private List<SubMenuModel> GetSubMenus()
        {
            List<SubMenuModel> source = new()
            {
                new SubMenuModel(8, 0, "OVERVIEW"),
                new SubMenuModel(9, 0, "PRESEASON"),
                new SubMenuModel(10, 0, "PATCH NOTES"),

                new SubMenuModel(11, 2, "HUB"),
                new SubMenuModel(12, 2, "FIND A TEAM"),
                new SubMenuModel(13, 2, "BRACKET"),
                new SubMenuModel(14, 2, "WINNERS"),
                new SubMenuModel(15, 2, "AWARDS"),

                new SubMenuModel(16, 4, "CHAMPIONS"),
                new SubMenuModel(17, 4, "SKINS"),
                new SubMenuModel(18, 4, "EMOTES"),
                new SubMenuModel(19, 4, "RUNES"),
                new SubMenuModel(20, 4, "SPELLS"),
                new SubMenuModel(21, 4, "ITEMS"),
                new SubMenuModel(22, 4, "ICONS"),
                new SubMenuModel(23, 4, "WARDS"),
                new SubMenuModel(24, 4, "CHROMAS"),

                new SubMenuModel(25, 7, "FEATURED"),
                new SubMenuModel(26, 7, "CHAMPIONS"),
                new SubMenuModel(27, 7, "SKINS"),
                new SubMenuModel(28, 7, "TFT"),
                new SubMenuModel(29, 7, "LOOT"),
                new SubMenuModel(30, 7, "ACCESSORIES"),

                new SubMenuModel(31, 3, "SUMMARY"),
                new SubMenuModel(32, 3, "MATCH HISTORY"),
                new SubMenuModel(33, 3, "RANKED"),
                new SubMenuModel(34, 3, "HIGHLIGHTS"),
                new SubMenuModel(35, 3, "STATS"),

                new SubMenuModel(31, 8, "PVP"),
                new SubMenuModel(32, 8, "AI 상대 대전"),
                new SubMenuModel(33, 8, "훈련"),
                new SubMenuModel(34, 8, "사용자 설정 게임 생성"),
                new SubMenuModel(35, 8, "사용자 설정 게임 참가"),

            };
            return source;
        }
        #endregion
    }
}