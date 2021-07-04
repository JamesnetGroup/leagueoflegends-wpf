namespace Leagueoflegends.DBEntity.Local.Entities.Schema
{
	public class ReqestFriends : Users
	{
		public ReqestFriends(Users user)
		{
			Seq = user.Seq;
			Name = user.Name;
			Created = user.Created;
			Updated = user.Updated;
		}

		public bool IsSent { get; set; }
	}
}
