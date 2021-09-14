using System.Linq;
using System.Collections.Generic;
using Lol.DBEntity.Local.Entities.Extend;
using Lol.DBEntity.Local.Entities.Implements;

namespace Lol.Main.Local.Collection
{
    public class FriendsCollection : List<IFriendsList>
    {
        #region GeneralFriendsCount

        public int GeneralFriendsCount => GeneralList.Children.Count;
        #endregion

        #region OfflineFriendsCount

        public int OfflineFriendsCount => OfflineList.Children.Count();
        #endregion

        #region TotalFriendsCount

        public int TotalFriendsCount => GeneralFriendsCount + OfflineFriendsCount;
        #endregion

        #region GeneralList 

        public FriendsHeader GeneralList { get; }
        #endregion

        #region OfflineList

        public FriendsHeader OfflineList { get; }
        #endregion

        #region Constructor

        public FriendsCollection(List<IFriendsList> items)
        {
            GeneralList = items[0] as FriendsHeader;
            OfflineList = items[1] as FriendsHeader;

            AddRange(items);
        }
        #endregion
    }
}
