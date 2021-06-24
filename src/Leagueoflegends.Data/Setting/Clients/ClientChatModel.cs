namespace Leagueoflegends.Data.Setting.Clients
{
	public class ClientChatModel
	{
		public bool SlangFilter { get; set; } = true;
		public bool LinkCaution { get; set; } = true;
		public bool MoreMenuVisible { get; set; } = true;
		public bool NewFriends { get; set; } = true;

		public ClientChatModel()
		{
		}
	}
}
