using Lol.Data.Setting;
using System.Collections.Generic;

namespace Lol.ExampleData.Setting
{
    public partial class ExamSettings
    {
        public static List<SettingMenuModel> GetSettingList()
        {
            List<SettingMenuModel> source = new()
            {
                new SettingMenuModel { Seq = 0, Category = "CATEGORY", Name = "CLIENT" },
                new SettingMenuModel { Seq = 1, Category = "CLIENT", Name = "GENERAL" },
                new SettingMenuModel { Seq = 2, Category = "CLIENT", Name = "NOTIFICATIONS" },
                new SettingMenuModel { Seq = 3, Category = "CLIENT", Name = "CHAT & FRIENDS" },
                new SettingMenuModel { Seq = 4, Category = "CLIENT", Name = "SOUND" },
                new SettingMenuModel { Seq = 5, Category = "CLIENT", Name = "VOICE" },
                new SettingMenuModel { Seq = 6, Category = "CLIENT", Name = "BLOCK LIST" },

                new SettingMenuModel { Seq = 7, Category = "CATEGORY", Name = "IN-GAME" },
                new SettingMenuModel { Seq = 8, Category = "IN-GAMES", Name = "HOTKEYS" },
                new SettingMenuModel { Seq = 9, Category = "IN-GAMES", Name = "SOUND" },
                new SettingMenuModel { Seq = 10, Category = "IN-GAMES", Name = "INTERFACE" },
                new SettingMenuModel { Seq = 11, Category = "IN-GAMES", Name = "GAME" },
                new SettingMenuModel { Seq = 12, Category = "IN-GAMES", Name = "REPLAYS" },

                new SettingMenuModel { Seq = 13, Category = "CATEGORY", Name = "ABOUT" },
                new SettingMenuModel { Seq = 14, Category = "ABOUT", Name = "VERIFICATION" },
                new SettingMenuModel { Seq = 15, Category = "ABOUT", Name = "PRIVACY NOTICE" },
                new SettingMenuModel { Seq = 16, Category = "ABOUT", Name = "TOU" },
                new SettingMenuModel { Seq = 17, Category = "ABOUT", Name = "THIRD-PARTY LICENSES" },
                new SettingMenuModel { Seq = 18, Category = "ABOUT", Name = "VERSION" }
            };
            return source;
        }
    }
}
