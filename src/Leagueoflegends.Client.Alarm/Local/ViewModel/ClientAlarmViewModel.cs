using Leagueoflegends.Data.Config;
using Leagueoflegends.Data.Setting.Clients;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;

namespace Leagueoflegends.Client.Alarm.Local.ViewModel
{
	public class ClientAlarmViewModel : ObservableObject
	{
		public ClientAlarmModel Model { get; set; }

		#region Constructor

		public ClientAlarmViewModel()
		{
			ConfigModel config = RiotConfig.LoadConfig();
			Model = config.Settings.ClientAlarm;
		}
		#endregion
	}
}
