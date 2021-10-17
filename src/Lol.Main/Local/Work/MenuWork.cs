using Lol.Data.Main;
using Lol.Foundation.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Main.Local.Work
{
    public class MenuWork : ObservableObject
    {
        #region Variables

        private readonly Action<MainMenuModel, List<SubMenuModel>> _menuCommand;
        #endregion

        #region Menus

        private MainMenuModel _currentMenu;
        public MainMenuModel CurrentMenu
        {
            get => _currentMenu;
            set { _currentMenu = value; OnPropertyChanged(); }
        }

        public List<MainMenuModel> Menus { get; }

        #endregion

        #region TotalSubMenus

        public List<SubMenuModel> TotalSubMenus { get; }
        #endregion

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

        public List<SubMenuModel> MenuChangedbyButtonClick(int seq)
        {
            CurrentMenu = Menus[seq];
            List<SubMenuModel> subMenus = TotalSubMenus.Where(x => x.MainSeq == CurrentMenu.Seq).ToList();

            return subMenus;
        }

        #region GetMenus

        private static List<MainMenuModel> GetMenus()
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

        private static List<SubMenuModel> GetSubMenus()
        {
            List<SubMenuModel> source = new()
            {
                new SubMenuModel(9, 0, "OVERVIEW"),
                new SubMenuModel(10, 0, "PRESEASON"),
                new SubMenuModel(11, 0, "PATCH NOTES"),

                new SubMenuModel(12, 2, "HUB"),
                new SubMenuModel(13, 2, "FIND A TEAM"),
                new SubMenuModel(14, 2, "BRACKET"),
                new SubMenuModel(15, 2, "WINNERS"),
                new SubMenuModel(16, 2, "AWARDS"),

                new SubMenuModel(17, 4, "CHAMPIONS"),
                new SubMenuModel(18, 4, "SKINS"),
                new SubMenuModel(19, 4, "EMOTES"),
                new SubMenuModel(20, 4, "RUNES"),
                new SubMenuModel(21, 4, "SPELLS"),
                new SubMenuModel(22, 4, "ITEMS"),
                new SubMenuModel(23, 4, "ICONS"),
                new SubMenuModel(24, 4, "WARDS"),
                new SubMenuModel(25, 4, "CHROMAS"),

                new SubMenuModel(26, 7, "FEATURED"),
                new SubMenuModel(27, 7, "CHAMPIONS"),
                new SubMenuModel(28, 7, "SKINS"),
                new SubMenuModel(29, 7, "TFT"),
                new SubMenuModel(30, 7, "LOOT"),
                new SubMenuModel(31, 7, "ACCESSORIES"),

                new SubMenuModel(32, 3, "SUMMARY"),
                new SubMenuModel(33, 3, "MATCH HISTORY"),
                new SubMenuModel(34, 3, "RANKED"),
                new SubMenuModel(35, 3, "HIGHLIGHTS"),
                new SubMenuModel(36, 3, "STATS"),

                new SubMenuModel(37, 8, "PVP"),
                new SubMenuModel(38, 8, "CO-OP VS. AI"),
                new SubMenuModel(39, 8, "TRAINING"),
                new SubMenuModel(40, 8, "CREATE CUSTOM"),
                new SubMenuModel(41, 8, "JOIN CUSTOM"),
                new SubMenuModel(42, 8, "RIFT"),
            };
            return source;
        }
        #endregion
    }
}