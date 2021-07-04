using Leagueoflegends.DBEntity.Local.Entities;
using Leagueoflegends.DBEntity.Local.Entities.Extend;
using System.Collections.Generic;
using System.Linq;

namespace Leagueoflegends.DBEntity.Local.Api
{
	public class GetSentFriends
	{
		public List<RequestUsers> Run(int mySeq)
		{
			using (var db = new RiotContext())
			{
				var users = db.Users
					.Where(x=>x.Seq != mySeq)
					.Select(x =>new RequestUsers(x))
					.ToList();

				return users;
			}
		}
	}
}
