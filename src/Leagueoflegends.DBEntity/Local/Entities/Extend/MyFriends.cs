using Leagueoflegends.DBEntity.Local.Entities.Implements;
using Leagueoflegends.DBEntity.Local.Entities.Schema;
using System;

namespace Leagueoflegends.DBEntity.Local.Entities.Extend
{
	public class MyFriends : Users, IFriendsList
	{
		public Type Type => GetType();

		public MyFriends(Users user)
		{
			Seq = user.Seq;
			Name = user.Name;
			Created = user.Created;
			Updated = user.Updated;
		}
	}
}
