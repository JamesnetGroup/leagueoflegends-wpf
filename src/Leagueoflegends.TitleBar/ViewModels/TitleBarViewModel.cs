using Leagueoflegends.Windowbase.Mvvm;
using System;
using System.Windows;
using System.Windows.Input;

namespace Leagueoflegends.TitleBar.ViewModels
{
	public class TitleBarViewModel : ObservableObject
	{
		#region Commands

		public ICommand TitleBarSelectCommand { get; }
		#endregion

		#region Constructor

		public TitleBarViewModel()
		{
			TitleBarSelectCommand = new RelayCommand<string>(ButtonClick);
		}
		#endregion

		#region ButtonClick

		private void ButtonClick(string tag)
		{
			switch (tag)
			{
				case "MIN": Window.GetWindow(View).WindowState = WindowState.Minimized; break;
				case "CLOSE": Environment.Exit(0); break;
			}
		}
		#endregion
	}
}
