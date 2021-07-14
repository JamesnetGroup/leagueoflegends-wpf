using Leagueoflegends.Data.Enums;
using Leagueoflegends.Data.Setting;
using System.Collections.Generic;

namespace Leagueoflegends.ExampleData.Setting
{
	public partial class ExamSettings
    {
        public static List<SettingMenuModel> GetSettingList()
        {
            List<SettingMenuModel> source = new()
			{
                new SettingMenuModel { Seq = 0, MenuType = SettingMenuType.Directory, Category = "카테고리", Name = "CLIENT" },
                new SettingMenuModel { Seq = 1, MenuType = SettingMenuType.Normal, Category = "CLIENT", Name = "GENERAL" },
                new SettingMenuModel { Seq = 2, MenuType = SettingMenuType.Alarm, Category = "CLIENT", Name = "NOTIFICATIONS" },
                new SettingMenuModel { Seq = 3, MenuType = SettingMenuType.ChatAndFriends, Category = "CLIENT", Name = "CHAT & FRIENDS" },
                new SettingMenuModel { Seq = 4, MenuType = SettingMenuType.Sound, Category = "CLIENT", Name = "SOUND" },
                new SettingMenuModel { Seq = 5, MenuType = SettingMenuType.Voice, Category = "CLIENT", Name = "VOICE" },
                new SettingMenuModel { Seq = 6, MenuType = SettingMenuType.BlockList, Category = "CLIENT", Name = "BLOCK LIST" },

                new SettingMenuModel { Seq = 7, MenuType = SettingMenuType.Directory, Category = "카테고리", Name = "IN-GAMES" },
                new SettingMenuModel { Seq = 8, MenuType = SettingMenuType.Key, Category = "IN-GAMES", Name = "HOTKEYS" },
                new SettingMenuModel { Seq = 9, MenuType = SettingMenuType.GameSound, Category = "IN-GAMES", Name = "SOUND" },
                new SettingMenuModel { Seq = 10, MenuType = SettingMenuType.Interface, Category = "IN-GAMES", Name = "INTERFACE" },
                new SettingMenuModel { Seq = 11, MenuType = SettingMenuType.Game, Category = "IN-GAMES", Name = "GAME" },
                new SettingMenuModel { Seq = 12, MenuType = SettingMenuType.Replay, Category = "IN-GAMES", Name = "REPLAYS" },

                new SettingMenuModel { Seq = 13, MenuType = SettingMenuType.Directory, Category = "카테고리", Name = "ABOUT" },
                new SettingMenuModel { Seq = 14, MenuType = SettingMenuType.Authority, Category = "ABOUT", Name = "VERIFICATION" },
                new SettingMenuModel { Seq = 15, MenuType = SettingMenuType.PersonalData, Category = "ABOUT", Name = "PRIVACY NOTICE" },
                new SettingMenuModel { Seq = 16, MenuType = SettingMenuType.Service, Category = "ABOUT", Name = "TOU" },
                new SettingMenuModel { Seq = 17, MenuType = SettingMenuType.License, Category = "ABOUT", Name = "THIRD-PARTY LICENSES" },
                new SettingMenuModel { Seq = 18, MenuType = SettingMenuType.Version, Category = "ABOUT", Name = "VERSION" }
            };
            return source;
        }
    }
}
