using Lol.Data.Local;

namespace Lol.Data.Main
{
    public class AddUserModel : FriendsModel
    {
        public bool IsSent { get; set; }
        public string NickName { get; set; }
        public string UserID { get; set; }
        public string Nation { get; set; }
        public int Level { get; set; }

        public AddUserModel(string name)
        {
            Name = name;
            IsSent = RandomHelper.Random.Next(0, 2) == 0;
            Level = RandomHelper.Random.Next(7, 300);
            Nation = "KR";
            Avatar = $"/Lol.Resources;component/Images/Square/{RandomHelper.Random.Next(0, 42)}.png";
        }
        public AddUserModel()
        {

        }
    }
}
