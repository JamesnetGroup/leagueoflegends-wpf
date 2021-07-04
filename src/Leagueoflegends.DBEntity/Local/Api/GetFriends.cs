using Leagueoflegends.DBEntity.Local.Entities;
using Leagueoflegends.DBEntity.Local.Entities.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Leagueoflegends.DBEntity.Local.Api
{
	public class GetFriends
	{
		public List<Users> Run(int mySeq)
		{
			using (var db = new RiotContext())
			{
				var users = from f in db.Friends
							where f.UserSeq == mySeq
							join u in db.Users
							on f.FriendsSeq equals u.Seq
							select u;

				return users.ToList();
			}
		}
	}
}
