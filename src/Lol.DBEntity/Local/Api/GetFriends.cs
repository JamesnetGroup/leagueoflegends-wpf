using Lol.DBEntity.Local.Entities;
using Lol.DBEntity.Local.Entities.Extend;
using Lol.DBEntity.Local.Entities.Implements;
using System.Collections.Generic;
using System.Linq;

namespace Lol.DBEntity.Local.Api
{
    public class GetFriends
    {
        public List<IFriendsList> Run(int mySeq)
        {
            using RiotContext db = new();

            var query = from f in db.Friends
                        where f.UserSeq == mySeq
                        join u in db.Users
                        on f.FriendsSeq equals u.Seq
                        select new MyFriends(u);

            var friends = query.ToList()
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
    }
}
