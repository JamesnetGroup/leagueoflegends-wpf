using Leagueoflegends.Data.Config;
using Leagueoflegends.Data.Setting.Clients;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;

namespace Leagueoflegends.Settings.Client.Local.ViewModels
{
	public class AlarmViewModel : ObservableObject
	{
		public AlarmModel Model { get; set; }

		#region Constructor

		public AlarmViewModel()
		{
			ConfigModel config = RiotConfig.LoadConfig();
			Model = config.Settings.Alarm;
		}
		#endregion
	}
}
