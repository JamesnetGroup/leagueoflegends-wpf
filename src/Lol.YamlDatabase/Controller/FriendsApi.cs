using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.YamlDatabase.Controller
{
    public class FriendsApi : LolDbContext
    {
        public List<IFriendsList> GetMyFriends(int mySeq)
        {
            // TODO: [Elena] Yaml DB 임시 작업중!
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
    }
}
