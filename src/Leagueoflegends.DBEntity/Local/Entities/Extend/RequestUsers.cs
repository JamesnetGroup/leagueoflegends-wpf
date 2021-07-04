using Leagueoflegends.DBEntity.Local.Entities.Schema;

namespace Leagueoflegends.DBEntity.Local.Entities.Extend
{
	public class RequestUsers : Users
	{
		public bool IsSent { get; set; }

		public RequestUsers(Users user)
		{
			Seq = user.Seq;
			Name = user.Name;
			Created = user.Created;
			Updated = user.Updated;
		}
	}
}
