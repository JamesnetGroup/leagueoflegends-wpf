using System.Collections.Generic;

namespace Leagueoflegends.Data.Main
{
	public class CommunityModel : UserModel
	{
        public string Header { get { return Name; } }
        public List<CommunityModel> Children { get; set; }
        public bool IsUser { get; set; }
        public bool IsGeneral { get; set; }
        public new string Status { get; set; }
        public string Avatar { get { return MD5; } }
    }
}
