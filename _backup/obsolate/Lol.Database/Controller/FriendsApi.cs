using Lol.Database.Entites.Core;
using Lol.Database.Entites.Schema;

namespace Lol.Database.Controller
{
    public class FriendsApi : LolDbContext
    {
        #region GetMyFriends

        public List<IFriendsList> GetMyFriends(int mySeq)
        {
            var users = Db.Users;

            var friends = Db.Friends.Where(x => x.UserSeq == mySeq)
                .Select(x => new MyFriends(users.First(u => x.FriendsSeq == u.Seq)))
                .OrderBy(x => x.Status)
                .ToList();

            FriendsHeader general = new("GENERAL", true);
            FriendsHeader offline = new("OFFLINE", true);

            List<IFriendsList> list = new();
            list.Add(general);
            list.Add(offline);

            general.Children.AddRange(friends.Where(x => x.Status > 0));
            offline.Children.AddRange(friends.Where(x => x.Status < 1));

            return list;
        }
        #endregion

        #region GetFriendRequests

        public List<RequestUsers> GetFriendRequests(int mySeq)
        {
            var users = Db.Users;

            var friends = Db.Friends.Where(x => x.UserSeq == mySeq)
                .Select(x => new MyFriends(users.First(u => x.FriendsSeq == u.Seq)))
                .OrderBy(x => x.Status)
                .ToList();

            var requests = friends
                .Select(x => new RequestUsers(x))
                .ToList();

            return requests;
        }
        #endregion
    }
}
