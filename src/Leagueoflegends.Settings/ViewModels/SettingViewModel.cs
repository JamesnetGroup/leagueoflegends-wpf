using System;
using System.Windows.Input;
using System.Collections.Generic;
using Leagueoflegends.Data.Setting;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;
using Leagueoflegends.Foundation.Riotcore;
using Leagueoflegends.ExampleData.Setting;
using Leagueoflegends.LayoutSupport.Controls;
using Leagueoflegends.Settings.Views;
using Leagueoflegends.Client.Normal.UI;
using Leagueoflegends.Client.Alarm.UI;
using Leagueoflegends.Client.Chat.UI;
using Leagueoflegends.Client.Sound.UI;
using Leagueoflegends.Client.Voice.UI.Views;
using Leagueoflegends.Client.Block.UI;
using Leagueoflegends.Client.Normal.Local.ViewModel;
using Leagueoflegends.Client.Alarm.Local.ViewModel;
using Leagueoflegends.Client.Chat.Local.ViewModel;
using Leagueoflegends.Client.Sound.Local.ViewModel;
using Leagueoflegends.Client.Voice.Local.ViewModel;
using Leagueoflegends.Client.Block.Local.ViewModel;

namespace Leagueoflegends.Settings.ViewModels
{
	public class SettingViewModel : ObservableObject
	{
		#region Variables

		private Action<IRiotUI> ViewClosed;
		private IRiotUI _currentView;
		private List<SettingMenuModel> _settingMenus;
		private SettingMenuModel _currentSettingMenu;

		private ClientNormalViewModel Normal;
		private ClientAlarmViewModel Alarm;
		private ClientChatViewModel Chat;
		private ClientSoundViewModel Sound;
		private ClientVoiceViewModel Voice;
		private ClientBlockViewModel Block;
		private Dictionary<int, IRiotUI> UIs { get; set; }
		#endregion 

		#region Command

		public ICommand CompleteCommand { get; set; }
		#endregion

		#region Menus

		public List<SettingMenuModel> SettingMenus
		{
			get => _settingMenus;
			set { _settingMenus = value; OnPropertyChanged(); }
		}

		public SettingMenuModel CurrentSettingMenu
		{
			get => _currentSettingMenu;
			set { _currentSettingMenu = value; OnPropertyChanged(); SettingMenuChanged(value); }
		}
		#endregion

		#region CurrentView

		public IRiotUI CurrentView
		{
			get => _currentView;
			set { _currentView = value; OnPropertyChanged(); }
		}
		#endregion

		#region Constructor

		public SettingViewModel(Action<IRiotUI> modalClose)
		{
			ViewClosed = modalClose;
			UIs = new();
			Normal = new ClientNormalViewModel();
			Alarm = new ClientAlarmViewModel();
			Chat = new ClientChatViewModel();
			Sound = new ClientSoundViewModel();
			Voice = new ClientVoiceViewModel();
			Block = new ClientBlockViewModel();

			SettingMenus = ExamSettings.GetSettingList();
			CompleteCommand = new RelayCommand<Modal>(CompleteClick);
		}
		#endregion

		#region SettingMenuChanged

		private void SettingMenuChanged(SettingMenuModel value)
		{
			IRiotUI content;
			int key;

			if (value != null)
			{
				key = value.Seq;
				content = value.Seq switch
				{
					1 => new ClientNormalView().SetVM(Normal),
					2 => new ClientAlarmView().SetVM(Alarm),
					3 => new ClientChatView().SetVM(Chat),
					4 => new ClientSoundView().SetVM(Sound),
					5 => new ClientVoiceView().SetVM(Voice),
					6 => new ClientBlockView().SetVM(Block),
					_ => new EmptyView()
				};

				if (!UIs.ContainsKey(key))
				{
					UIs.Add(key, content);
				}

				CurrentView = UIs[key];
			}
		}
		#endregion

		#region CompleteClick

		private void CompleteClick(Modal obj)
		{
			ViewClosed.Invoke(View);

			SettingModel setting = RiotConfig.Config.Settings;
			setting.ClientNormal = Normal.Model;
			setting.ClientAlarm = Alarm.Model;
			setting.ClientChat = Chat.Model;
			setting.ClientSound = Sound.Model;
			setting.ClientVoice = Voice.Model;

			RiotConfig.SaveSettings(setting);
		}
		#endregion
	}
}
