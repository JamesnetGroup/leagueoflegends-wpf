using Leagueoflegends.DBEntity.Local.Entities.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leagueoflegends.Friends.Local.Model
{
	public class FriendsDataModel : Users
	{
		public bool IsSent { get; set; }
	}
}
