using Leagueoflegends.DBEntity.Local.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leagueoflegends.DBEntity.Local.Api
{
	public class GetUsers
	{
		public object Run()
		{
			using (var db = new RiotContext())
			{
				var users = db.Users
					.ToList();

				return users;
			}
		}
	}
}
