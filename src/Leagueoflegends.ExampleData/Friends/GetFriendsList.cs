using Leagueoflegends.Data.Main;
using System.Collections.Generic;

namespace Leagueoflegends.ExampleData.Friends
{
	public partial class ExamFriends
	{
		public static List<CommunityModel> GetFriendsList()
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

			return friends;
		}
	}
}
