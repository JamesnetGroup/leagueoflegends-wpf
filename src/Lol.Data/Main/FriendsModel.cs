using System.Collections.Generic;

namespace Lol.Data.Main
{
    public class FriendsModel
    {
        public string Name { get; set; }
        public bool IsExpanded { get; set; }
        public bool IsUser { get; set; }
        public int Connect { get; set; }
        public int Status { get; set; }
        public string Avatar { get; set; }
        public List<FriendsModel> Children { get; set; }

        public FriendsModel()
        {

        }

        public FriendsModel(string header)
        {
            Name = header;
            IsUser = false;
            IsExpanded = true;
            Children = new();
        }

        public FriendsModel(int online, int status, int avatar, string header)
        {
            IsUser = true;
            Status = status;
            Connect = online;
            Avatar = $"/Lol.Resources;component/Images/Square/{avatar}.png";
            Name = header;
        }
    }
}
