using Leagueoflegends.DBEntity.Local.Entities;
using Leagueoflegends.DBEntity.Local.Entities.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Leagueoflegends.DBEntity.Local.Api
{
	public class GetSentFriends
	{
		public List<ReqestFriends> Run(int mySeq)
		{
			using (var db = new RiotContext())
			{
				var users = db.Users
					.Where(x=>x.Seq != mySeq)
					.Select(x =>new ReqestFriends(x))
					.ToList();

				return users;
			}
		}
	}
}
