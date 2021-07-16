using Leagueoflegends.Data.Config;
using Leagueoflegends.Data.Setting.Clients;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;

namespace Leagueoflegends.Settings.Client.Local.ViewModels
{
	public class SoundViewModel : ObservableObject
	{
		public SoundModel Model { get; set; }

		#region Constructor

		public SoundViewModel()
		{
			ConfigModel config = RiotConfig.LoadConfig();
			Model = config.Settings.Sound;
		}
		#endregion
	}
}
