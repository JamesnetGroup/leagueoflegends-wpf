using Leagueoflegends.Data.Config;
using Leagueoflegends.Data.Setting.Clients;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;

namespace Leagueoflegends.Client.Sound.Local.ViewModel
{
	public class ClientSoundViewModel : ObservableObject
	{
		public ClientSoundModel Model { get; set; }

		#region Constructor

		public ClientSoundViewModel()
		{
			ConfigModel config = RiotConfig.LoadConfig();
			Model = config.Settings.ClientSound;
		}
		#endregion
	}
}
