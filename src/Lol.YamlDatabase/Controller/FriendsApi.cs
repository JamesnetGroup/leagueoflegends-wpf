using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;
using Lol.YamlDatabase.Entites.Statics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Lol.YamlDatabase.Controller
{
    public class FriendsApi : LolDbContext
    {
        public List<IFriendsList> GetMyFriends(int mySeq)
        {
            // TODO: [Elena] Yaml DB 임시 작업중!
            var friends1 = Db.Friends.Where(x => x.UserSeq == mySeq).ToList();
            var users1 = Db.Users;

            var friends = friends1.Select(x => new MyFriends(users1.First(u => x.FriendsSeq == u.Seq))).ToList()
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
            var friends1 = Db.Friends.Where(x => x.UserSeq == mySeq).ToList();
            var users1 = Db.Users;

            var friends = friends1.Select(x => new MyFriends(users1.First(u => x.FriendsSeq == u.Seq))).ToList()
                .OrderBy(x => x.Status)
                .ToList();

            var users = friends
                .Select(x => new RequestUsers(x))
                .ToList();
            return users;
        }
    }
}
