using Leagueoflegends.Data.Main;
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

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

			general.Children.Add(new(0, 0, 0, "James Lee"));
			general.Children.Add(new(0, 0, 1, "Elena Kim"));
			general.Children.Add(new(0, 0, 2, "Hide on bush"));
			general.Children.Add(new(0, 0, 3, "Jon Skeet"));

			offline.Children.Add(new(0, 1, 0, "Angela Merkel"));
			offline.Children.Add(new(0, 1, 1, "Elon Musk"));
			offline.Children.Add(new(0, 1, 2, "Satya Nadella"));
			offline.Children.Add(new(0, 1, 3, "Sundar Pichai"));

			return friends;
		}
	}
}
