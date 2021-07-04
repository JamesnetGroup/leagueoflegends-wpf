using Leagueoflegends.Data.Main;
using Leagueoflegends.DBEntity.Local.Entities.Extend;
using Leagueoflegends.DBEntity.Local.Entities.Implements;
using System.Collections.Generic;
using System.Linq;

namespace Leagueoflegends.Main.Local.Collection
{
	public class FriendsCollection : List<IFriendsList>
	{
		public int GeneralFriendsCount => GeneralList.Children.Count();
		public int OfflineFriendsCount => OfflineList.Children.Count();
		public int TotalFriendsCount => GeneralFriendsCount + OfflineFriendsCount;

		public FriendsHeader GeneralList { get; }
		public FriendsHeader OfflineList { get; }

		public FriendsCollection(List<IFriendsList> items)
		{
		 	GeneralList = items[0] as FriendsHeader;
			OfflineList = items[1] as FriendsHeader;

			AddRange(items);
		}
	}
}
