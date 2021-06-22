using System.Collections.Generic;

namespace Leagueoflegends.Data.Main
{
	public class FriendsModel
	{
        public string Header { get; set; }
        public bool IsExpanded { get; set; }
        public bool IsUser { get; set; }
        public int Connect { get; set; }
        public int Status { get; set; }
        public string Avatar { get; set; }
        public List<FriendsModel> Children { get; set; }

        public FriendsModel(string header)
        {
            Header = header;
            IsUser = false;
            IsExpanded = true;
            Children = new();
        }

        public FriendsModel(int online, int status, int avatar, string header)
        {
            IsUser = true;
			Status = status;
            Connect = online;
            Avatar = $"/Leagueoflegends.Resources;component/Images/Square/{avatar}.png";
            Header = header;
        }
    }
}
