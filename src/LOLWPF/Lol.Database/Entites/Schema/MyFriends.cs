using Lol.DBEntity.Common;

namespace Lol.Database.Entites.Schema
{
    public class MyFriends : Users, IFriendsList
    {
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
    }
}
