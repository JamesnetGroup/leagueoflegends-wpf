using Leagueoflegends.Data.Main;
using System.Collections.Generic;
using System.Linq;

namespace Leagueoflegends.Main.Local.Collection
{
	public class FriendsCollection : List<FriendsModel>
	{
		public int GeneralFriendsCount => this[0].Children.Count();
		public int OfflineFriendsCount => this[1].Children.Count();
		public int TotalFriendsCount => GeneralFriendsCount + OfflineFriendsCount;

		public FriendsCollection(List<FriendsModel> items)
		{
			AddRange(items);
		}
	}
}
