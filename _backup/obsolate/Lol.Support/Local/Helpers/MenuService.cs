using Lol.Support.Local.Models;
using System;
using System.Collections.Generic;

namespace Lol.Support.Local.Helpers
{
    public class MenuService
    {
        public event EventHandler<BackgroundChangedEventArgs> UpdateChanged;
        public event EventHandler<MenuChangedEventArgs> MenuChanged;
        public event EventHandler<BackgroundChangedEventArgs> BackgroundChanged;
        public event EventHandler<EventArgs> ModalClosed;

        public void ChangeBackground(Uri uri)
        {
            BackgroundChanged?.Invoke(this, new BackgroundChangedEventArgs(uri));
        }

        public void ChangeMenu(int menuId)
        {
            MenuChanged?.Invoke(this, new MenuChangedEventArgs(menuId));
        }

        public void GoHome()
        {
            MenuChanged?.Invoke(this, new MenuChangedEventArgs("Home"));
        }

        public void ModeChange()
        {
            MenuChanged?.Invoke(this, new MenuChangedEventArgs("ModeChange"));
        }

        public void CloseModal()
        {
            ModalClosed?.Invoke(this, new EventArgs());
        }

        public List<MainMenuInfo> GetMenus()
        {
            List<MainMenuInfo> source = new()
            {
                new MainMenuInfo(0, "HOME", "TEXT"),
                new MainMenuInfo(1, "TFT", "TEXT", "TeamFightContent"),
                new MainMenuInfo(2, "CLASH", "TEXT"),
                new MainMenuInfo(3, "Profile", "ICON"),
                new MainMenuInfo(4, "Collection", "ICON"),
                new MainMenuInfo(5, "Loot", "ICON", "LootContent"),
                new MainMenuInfo(6, "My Shop", "ICON", "MyShopContent"),
                new MainMenuInfo(7, "Store", "ICON"),
                new MainMenuInfo(8, "GAME", "TEXT")
            };
            return source;
        }

        public List<SubMenuInfo> GetSubMenus()
        {
            List<SubMenuInfo> source = new()
            {
                new SubMenuInfo(9, 0, "OVERVIEW", "OverViewContent"),
                new SubMenuInfo(10, 0, "PRESEASON"),
                new SubMenuInfo(11, 0, "PATCH NOTES"),
                new SubMenuInfo(44, 0, "AVATAR CREATE", "AvatarContent"),

                new SubMenuInfo(12, 2, "HUB", "HubContent"),
                new SubMenuInfo(13, 2, "FIND A TEAM"),
                new SubMenuInfo(14, 2, "BRACKET"),
                new SubMenuInfo(15, 2, "WINNERS", "WinnersContent"),
                new SubMenuInfo(16, 2, "AWARDS"),

                new SubMenuInfo(17, 4, "CHAMPIONS", "ChampionsContent"),
                new SubMenuInfo(18, 4, "SKINS", "SkinContent"),
                new SubMenuInfo(19, 4, "EMOTES"),
                new SubMenuInfo(20, 4, "RUNES", "RuneContent"),
                new SubMenuInfo(21, 4, "SPELLS", "SpellsContent"),
                new SubMenuInfo(22, 4, "ITEMS", "ItemContent"),
                new SubMenuInfo(23, 4, "ICONS"),
                new SubMenuInfo(24, 4, "WARDS"),
                new SubMenuInfo(25, 4, "CHROMAS"),

                new SubMenuInfo(26, 7, "FEATURED", "StoreHomeContent"),
                new SubMenuInfo(27, 7, "CHAMPIONS", "StoreChampionsContent"),
                new SubMenuInfo(28, 7, "SKINS", "StoreSkinContent"),
                new SubMenuInfo(29, 7, "TFT", "TFTContent"),
                new SubMenuInfo(30, 7, "LOOT", "StoreLootContent"),
                new SubMenuInfo(31, 7, "ACCESSORIES", "EtcContent"),

                new SubMenuInfo(32, 3, "SUMMARY", "SummaryContent"),
                new SubMenuInfo(33, 3, "MATCH HISTORY", "HistoryContent"),
                new SubMenuInfo(34, 3, "RANKED"),
                new SubMenuInfo(35, 3, "HIGHLIGHTS", "HighlightContent"),
                new SubMenuInfo(36, 3, "STATS"),

                new SubMenuInfo(37, 8, "PVP", "PvpContent"),
                new SubMenuInfo(38, 8, "CO-OP VS. AI"),
                new SubMenuInfo(39, 8, "TRAINING"),
                new SubMenuInfo(40, 8, "CREATE CUSTOM", "CreateCustomContent"),
                new SubMenuInfo(41, 8, "JOIN CUSTOM", "JoinCustomContent"),
                new SubMenuInfo(42, 8, "RIFT"),
                new SubMenuInfo(43, 8, "CUSTOM GAMEROOM")
            };
            return source;
        }

        public void Update(int key)
        {
            UpdateChanged?.Invoke(this, new BackgroundChangedEventArgs(key));
        }
    }
}
