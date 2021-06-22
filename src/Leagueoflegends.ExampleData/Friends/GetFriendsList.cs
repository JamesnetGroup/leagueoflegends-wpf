using Leagueoflegends.Data.Main;
using System.Collections.Generic;

namespace Leagueoflegends.ExampleData.Friends
{
	public partial class ExamFriends
	{
		public static List<FriendsModel> GetFriendsList()
		{
			List<FriendsModel> friends = new();

			FriendsModel general = new("GENERAL");
			FriendsModel offline = new("OFFLINE");
			
			friends.Add(general);
			friends.Add(offline);

			general.Children = new()
			{
				new(0, 0, 0, "James Lee"),
				new(0, 0, 1, "Elena Kim"),
				new(0, 0, 2, "Hide on bush"),
				new(0, 0, 3, "Jon Skeet")
			};

			offline.Children = new()
			{
				new(0, 1, 0, "Angela Merkel"),
				new(0, 1, 1, "Elon Musk"),
				new(0, 1, 2, "Satya Nadella"),
				new(0, 1, 3, "Sundar Pichai")
			};

			return friends;
		}
	}
}
