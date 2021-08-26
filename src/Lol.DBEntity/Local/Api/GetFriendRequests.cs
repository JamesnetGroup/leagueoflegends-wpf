using System.Linq;
using System.Collections.Generic;
using Lol.DBEntity.Local.Entities;
using Lol.DBEntity.Local.Entities.Extend;

namespace Lol.DBEntity.Local.Api
{
	public class GetFriendRequests
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
