using Leagueoflegends.DBEntity.Local.Entities.Implements;
using System;
using System.Collections.Generic;

namespace Leagueoflegends.DBEntity.Local.Entities.Extend
{
	public class FriendsHeader : IFriendsList
	{
		public bool IsExpanded { get; set; }
		public List<MyFriends> Children { get; set; }
		public string Header { get; set; }
		public Type Type => GetType();
		public FriendsHeader(string header)
		{
			Header = header;
			Children = new List<MyFriends>();
		}
	}
}
