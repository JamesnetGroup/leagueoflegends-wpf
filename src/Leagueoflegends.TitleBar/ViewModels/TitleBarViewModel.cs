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

		public ICommand TitleBarSelectCommand { get; }
		#endregion

		#region Constructor

		public TitleBarViewModel()
		{
			TitleBarSelectCommand = new RelayCommand<object>(ButtonClick);
		}
		#endregion

		#region ButtonClick

		private void ButtonClick(object obj)
		{
			Button btn = (Button)obj;

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
