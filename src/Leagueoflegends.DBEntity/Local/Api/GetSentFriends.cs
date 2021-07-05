using System.Linq;
using System.Collections.Generic;
using Leagueoflegends.DBEntity.Local.Entities;
using Leagueoflegends.DBEntity.Local.Entities.Extend;

namespace Leagueoflegends.DBEntity.Local.Api
{
	public class GetSentFriends
	{
		public List<RequestUsers> Run(int mySeq)
		{
			using RiotContext db = new();
			var users = db.Users
				.Where(x => x.Seq != mySeq)
				.Select(x => new RequestUsers(x))
				.ToList();

			return users;
		}
	}
}
