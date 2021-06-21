using Leagueoflegends.Windowbase.Mvvm;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Leagueoflegends.TitleBar.ViewModels
{
	public class TitleBarViewModel : ObservableObject
	{
		#region Commands

		public ICommand SettingCommand { get; }
		public ICommand TitleBarSelectCommand { get; }
		#endregion

		#region Constructor

		public TitleBarViewModel(RelayCommand<object> settingCommand)
		{
			SettingCommand = settingCommand;
			TitleBarSelectCommand = new RelayCommand<object>(ButtonClick);
		}
		#endregion

		#region ButtonClick

		private void ButtonClick(object obj)
		{
			ContentControl btn = (ContentControl)obj;

			switch (btn.Tag)
			{
				case "MIN":
					Window window = Window.GetWindow(obj as DependencyObject);
					window.WindowState = WindowState.Minimized;
					break;
				case "CLOSE":
					Environment.Exit(0);
					break;
				default:
					break;
			}
		}
		#endregion
	}
}
