using Leagueoflegends.Client.Normal.ViewModels;
using Leagueoflegends.Client.Normal.Views;
using Leagueoflegends.Data.Setting;
using Leagueoflegends.ExampleData.Setting;
using Leagueoflegends.LayoutSupport.Controls;
using Leagueoflegends.Settings.Views;
using Leagueoflegends.Windowbase.Mvvm;
using Leagueoflegends.Windowbase.Riotcore;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Leagueoflegends.Settings.ViewModels
{
	public class SettingViewModel : ObservableObject
	{
		private Action<object> ViewClosed;
		private IRiotUIElement _currentView;
		private List<SettingMenuModel> _settingMenus;
		private SettingMenuModel _currentSettingMenu;
		private Dictionary<int, IRiotUIElement> UIs { get; set; }

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

		public IRiotUIElement CurrentView
		{
			get => _currentView;
			set { _currentView = value; OnPropertyChanged(); }
		}
		#endregion

		#region Constructor

		public SettingViewModel(Action<object> _viewClosed)
		{
			ViewClosed = _viewClosed;

			UIs = new();
			SettingMenus = ExamSettings.GetSettingList();
			CompleteCommand = new RelayCommand<DarkBackground>(CompleteClick);
		}
		#endregion

		#region SettingMenuChanged

		private void SettingMenuChanged(SettingMenuModel value)
		{
			IRiotUIElement content;
			int key;

			if (value != null)
			{
				key = value.Seq;
				content = value.Seq switch
				{
					1 => new ClientNormalView().UseViewModel(new ClientNormalViewModel()),
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

		private void CompleteClick(DarkBackground obj)
		{
			ViewClosed.Invoke(this);
		}
		#endregion
	}
}
