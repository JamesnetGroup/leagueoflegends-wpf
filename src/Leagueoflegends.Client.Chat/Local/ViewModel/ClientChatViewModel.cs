using Leagueoflegends.Data.Config;
using Leagueoflegends.Data.Setting.Clients;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;

namespace Leagueoflegends.Client.Chat.Local.ViewModel
{
	public class ClientChatViewModel : ObservableObject
	{
		public ClientChatModel Model { get; set; }

		#region Constructor

		public ClientChatViewModel()
		{
			ConfigModel config = RiotConfig.LoadConfig();
			Model = config.Settings.ClientChat;
		}
		#endregion
	}
}
