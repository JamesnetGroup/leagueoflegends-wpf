using Lol.Database.Entites.Schema;

namespace Lol.Database.Collection
{
    //TODO: [Kevin] Lol.Main.Local.Collection 에서 변경 방생성 할 때 FriendsCollection 데이터가 필요
    //              일단 Lol.Database에 옮겨놓긴 했으나 여기에 놓고 사용해야 하는지는 추후 협의
    public class FriendsCollection : List<IFriendsList>
    {
        #region GeneralFriendsCount

        public int GeneralFriendsCount => GeneralList.Children.Count;
        #endregion

        #region OfflineFriendsCount

        public int OfflineFriendsCount => OfflineList.Children.Count;
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
