using Leagueoflegends.DBEntity.Local.Entities;
using Leagueoflegends.DBEntity.Local.Entities.Extend;
using Leagueoflegends.DBEntity.Local.Entities.Implements;
using System.Collections.Generic;
using System.Linq;

namespace Leagueoflegends.DBEntity.Local.Api
{
	public class GetFriends
	{
		public List<IFriendsList> Run(int mySeq)
		{
			using RiotContext db = new();

			var users = from f in db.Friends
						where f.UserSeq == mySeq
						join u in db.Users
						on f.FriendsSeq equals u.Seq
						select new MyFriends(u);

			List<IFriendsList> list = new();
			FriendsHeader general = new("GENERAL", true);
			FriendsHeader offline = new("OFFLINE", false);

			general.Children.AddRange(users.Take(6).ToList());
			offline.Children.AddRange(users.Skip(6).ToList());

			list.Add(general);
			list.Add(offline);

			return list;
		}
	}
}
