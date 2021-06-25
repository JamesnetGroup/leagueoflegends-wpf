using Leagueoflegends.Data.Codes;
using Leagueoflegends.Data.Config;
using Leagueoflegends.Data.Setting.Clients;
using Leagueoflegends.ExampleData.Setting;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;
using System.Collections.Generic;

namespace Leagueoflegends.Client.Voice.Local.ViewModel
{
	public class ClientVoiceViewModel : ObservableObject
	{
		private List<AudioDevice> _deviceList;

		public ClientVoiceModel Model { get; set; }

		#region DeviceList

		public List<AudioDevice> DeviceList
		{
			get => _deviceList;
			set { _deviceList = value; OnPropertyChanged(); }
		}
		#endregion

		#region Constructor

		public ClientVoiceViewModel()
		{
			DeviceList = ExamSettings.GetAudioDeviceList();

			ConfigModel config = RiotConfig.LoadConfig();
			Model = config.Settings.ClientVoice;
		}
		#endregion
	}
}
