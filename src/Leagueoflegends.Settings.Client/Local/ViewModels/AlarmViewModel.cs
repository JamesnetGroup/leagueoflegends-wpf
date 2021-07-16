using Leagueoflegends.Data.Config;
using Leagueoflegends.Data.Setting.Clients;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;

namespace Leagueoflegends.Settings.Client.Local.ViewModels
{
	public class AlarmViewModel : ObservableObject
	{
		public ClientAlarmModel Model { get; set; }

		#region Constructor

		public AlarmViewModel()
		{
			ConfigModel config = RiotConfig.LoadConfig();
			Model = config.Settings.ClientAlarm;
		}
		#endregion
	}
}
