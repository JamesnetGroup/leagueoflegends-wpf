using Lol.DBEntity.Common;
using Lol.DBEntity.Local.Api;
using Lol.DBEntity.Local.Entities.Implements;
using Lol.DBEntity.Local.Entities.Schema;
using System;

namespace Lol.DBEntity.Local.Entities.Extend
{
    public class MyFriends : Users, IFriendsList
    {
        private UsersModel usersModel;

        public Type Type => GetType();

        public int Status { get; set; }

        public MyFriends(Users user)
        {
            Seq = user.Seq;
            Name = user.Name;
            Created = user.Created;
            Updated = user.Updated;
            Status = RandomHelper.Next(0, 4);
        }

        public MyFriends(UsersModel user)
        {
            Seq = user.Seq;
            Name = user.Name;
            Created = user.Created;
            Updated = user.Updated;
            Status = RandomHelper.Next(0, 4);
        }
    }
}
