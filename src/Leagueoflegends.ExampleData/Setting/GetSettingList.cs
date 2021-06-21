using Leagueoflegends.Data.Enums;
using Leagueoflegends.Data.Setting;
using System.Collections.Generic;

namespace Leagueoflegends.ExampleData.Setting
{
	public class ExamSettings
    {
        public static List<SettingMenuModel> GetSettingList()
        {
            List<SettingMenuModel> source = new()
			{
                new SettingMenuModel { Seq = 0, MenuType = SettingMenuType.Directory, Category = "카테고리", Name = "클라이언트" },
                new SettingMenuModel { Seq = 1, MenuType = SettingMenuType.Normal, Category = "클라이언트", Name = "일반" },
                new SettingMenuModel { Seq = 2, MenuType = SettingMenuType.Alarm, Category = "클라이언트", Name = "알림" },
                new SettingMenuModel { Seq = 3, MenuType = SettingMenuType.ChatAndFriends, Category = "클라이언트", Name = "채팅 & 친구" },
                new SettingMenuModel { Seq = 4, MenuType = SettingMenuType.Sound, Category = "클라이언트", Name = "음향" },
                new SettingMenuModel { Seq = 5, MenuType = SettingMenuType.Voice, Category = "클라이언트", Name = "음성" },
                new SettingMenuModel { Seq = 6, MenuType = SettingMenuType.BlockList, Category = "클라이언트", Name = "차단 목록" },

                new SettingMenuModel { Seq = 7, MenuType = SettingMenuType.Directory, Category = "카테고리", Name = "게임" },
                new SettingMenuModel { Seq = 8, MenuType = SettingMenuType.Key, Category = "게임", Name = "단축키" },
                new SettingMenuModel { Seq = 9, MenuType = SettingMenuType.GameSound, Category = "게임", Name = "음향" },
                new SettingMenuModel { Seq = 10, MenuType = SettingMenuType.Interface, Category = "게임", Name = "인터페이스" },
                new SettingMenuModel { Seq = 11, MenuType = SettingMenuType.Game, Category = "게임", Name = "게임" },
                new SettingMenuModel { Seq = 12, MenuType = SettingMenuType.Replay, Category = "게임", Name = "리플레이" },

                new SettingMenuModel { Seq = 13, MenuType = SettingMenuType.Directory, Category = "카테고리", Name = "세부 정보" },
                new SettingMenuModel { Seq = 14, MenuType = SettingMenuType.Authority, Category = "세부 정보", Name = "인증" },
                new SettingMenuModel { Seq = 15, MenuType = SettingMenuType.PersonalData, Category = "세부 정보", Name = "개인정보 처리방침" },
                new SettingMenuModel { Seq = 16, MenuType = SettingMenuType.Service, Category = "세부 정보", Name = "서비스 약관" },
                new SettingMenuModel { Seq = 17, MenuType = SettingMenuType.License, Category = "세부 정보", Name = "외부 라이선스" },
                new SettingMenuModel { Seq = 18, MenuType = SettingMenuType.Version, Category = "세부 정보", Name = "버전" }
            };
            return source;
        }
    }
}
