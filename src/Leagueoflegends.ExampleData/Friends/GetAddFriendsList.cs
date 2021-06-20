using Leagueoflegends.Data.Main;
using System.Collections.Generic;

namespace Leagueoflegends.ExampleData.Friends
{
	public partial class ExamFriends
    {
        public static List<AddFriendsModel> GetAddFriendsList()
        {
            var friends = new List<AddFriendsModel>
            {
                new AddFriendsModel { IsSent = true, NickName = "elenakim", UserID = "elenakim", Nation = "KR", Level = 5, Avatar="/Leagueoflegends.Resources;component/Images/Square/0.png" },
                new AddFriendsModel { IsSent = false, NickName = "조이블랑탈론", UserID = "joyblang", Nation = "KR", Level = 178, Avatar="/Leagueoflegends.Resources;component/Images/Square/1.png" },
                new AddFriendsModel { IsSent = false, NickName = "야 허건 넣을게", UserID = "yayaya", Nation = "KR", Level = 12, Avatar="/Leagueoflegends.Resources;component/Images/Square/10.png" },
                new AddFriendsModel { IsSent = false, NickName = "명학이는 명학해", UserID = "myunghak", Nation = "KR", Level = 33, Avatar="/Leagueoflegends.Resources;component/Images/Square/11.png" },
                new AddFriendsModel { IsSent = false, NickName = "짱루짱무", UserID = "jjangllu", Nation = "KR", Level = 25, Avatar="/Leagueoflegends.Resources;component/Images/Square/12.png" },
                new AddFriendsModel { IsSent = false, NickName = "이 진 썩", UserID = "leejin", Nation = "KR", Level = 54, Avatar="/Leagueoflegends.Resources;component/Images/Square/13.png" },
                new AddFriendsModel { IsSent = false, NickName = "flyETH", UserID = "flyETH", Nation = "US", Level = 5, Avatar="/Leagueoflegends.Resources;component/Images/Square/14.png" },
                new AddFriendsModel { IsSent = false, NickName = "생각좀해라서폿아", UserID = "thinkkk", Nation = "KR", Level = 71, Avatar="/Leagueoflegends.Resources;component/Images/Square/15.png" },
                new AddFriendsModel { IsSent = false, NickName = "개뒷치기", UserID = "wallwall", Nation = "KR", Level = 5, Avatar="/Leagueoflegends.Resources;component/Images/Square/16.png" },
                new AddFriendsModel { IsSent = false, NickName = "234923058205", UserID = "2349230", Nation = "CH", Level = 2, Avatar="/Leagueoflegends.Resources;component/Images/Square/17.png" },
                new AddFriendsModel { IsSent = false, NickName = "MAYBLE", UserID = "MAYBLE", Nation = "UK", Level = 14, Avatar="/Leagueoflegends.Resources;component/Images/Square/18.png" },
                new AddFriendsModel { IsSent = false, NickName = "다마고치 썸", UserID = "ssum", Nation = "KR", Level = 3, Avatar="/Leagueoflegends.Resources;component/Images/Square/19.png" },
                new AddFriendsModel { IsSent = false, NickName = "준우는휴가철", UserID = "jjun", Nation = "KR", Level = 45, Avatar="/Leagueoflegends.Resources;component/Images/Square/2.png" },
                new AddFriendsModel { IsSent = false, NickName = "대구박살남친구", UserID = "dkfff", Nation = "KR", Level = 5, Avatar="/Leagueoflegends.Resources;component/Images/Square/20.png" },
                new AddFriendsModel { IsSent = false, NickName = "햄버거피자짜장면", UserID = "hungry", Nation = "KR", Level = 92, Avatar="/Leagueoflegends.Resources;component/Images/Square/21.png" },
                new AddFriendsModel { IsSent = false, NickName = "이응5", UserID = "okayokay", Nation = "KR", Level = 5, Avatar="/Leagueoflegends.Resources;component/Images/Square/22.png" },
                new AddFriendsModel { IsSent = false, NickName = "GIVE ME BUSH", UserID = "bushmegive", Nation = "CA", Level = 10, Avatar="/Leagueoflegends.Resources;component/Images/Square/23.png" },
                new AddFriendsModel { IsSent = false, NickName = "바위개와칼날부리", UserID = "rockaby", Nation = "KR", Level = 63, Avatar="/Leagueoflegends.Resources;component/Images/Square/24.png" },
                new AddFriendsModel { IsSent = false, NickName = "단무지두장", UserID = "jjajang", Nation = "KR", Level = 42, Avatar="/Leagueoflegends.Resources;component/Images/Square/25.png" },
                new AddFriendsModel { IsSent = false, NickName = "시방누구여", UserID = "whoareyou", Nation = "KR", Level = 60, Avatar="/Leagueoflegends.Resources;component/Images/Square/26.png" },
                new AddFriendsModel { IsSent = false, NickName = "댁 우", UserID = "daeckwoo", Nation = "KR", Level = 2, Avatar="/Leagueoflegends.Resources;component/Images/Square/27.png" },
                new AddFriendsModel { IsSent = false, NickName = "세라핑핑이", UserID = "pingping", Nation = "KR", Level = 5, Avatar="/Leagueoflegends.Resources;component/Images/Square/28.png" },
                new AddFriendsModel { IsSent = false, NickName = "슈퍼아파트", UserID = "superduper", Nation = "KR", Level = 58, Avatar="/Leagueoflegends.Resources;component/Images/Square/29.png" },
                new AddFriendsModel { IsSent = false, NickName = "와르르맨숀", UserID = "jjanggu", Nation = "KR", Level = 7, Avatar="/Leagueoflegends.Resources;component/Images/Square/3.png" },
                new AddFriendsModel { IsSent = false, NickName = "집게사장", UserID = "sponge", Nation = "KR", Level = 32, Avatar="/Leagueoflegends.Resources;component/Images/Square/30.png" },
                new AddFriendsModel { IsSent = false, NickName = "꼬북좌", UserID = "kkobbuk", Nation = "KR", Level = 37, Avatar="/Leagueoflegends.Resources;component/Images/Square/31.png" },
                new AddFriendsModel { IsSent = false, NickName = "칙칙한초코칩", UserID = "chochock", Nation = "KR", Level = 74, Avatar="/Leagueoflegends.Resources;component/Images/Square/32.png" },
                new AddFriendsModel { IsSent = false, NickName = "4598583233", UserID = "4598583233", Nation = "JP", Level = 1, Avatar="/Leagueoflegends.Resources;component/Images/Square/33.png" },
                new AddFriendsModel { IsSent = false, NickName = "퇴사언제하지", UserID = "quitjob", Nation = "KR", Level = 3, Avatar="/Leagueoflegends.Resources;component/Images/Square/34.png" }
            };
            return friends;
        }
    }
}
