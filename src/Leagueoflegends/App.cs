using Leagueoflegends.Foundation.Riotbase;
using Leagueoflegends.Main.Local.ViewModel;
using Leagueoflegends.Main.UI.Views;
using System;
using System.Windows;

namespace Leagueoflegends
{
	public class App : RiotApp
	{
		public App()
		{

		}

		protected override void OnStartup(StartupEventArgs e)
		{
			bool dialogResult = true;

			while (dialogResult)
			{
				ShutdownMode = ShutdownMode.OnExplicitShutdown;
				MainView main = new()
				{
					DataContext = new MainViewModel()
				};

				_ = main.ShowDialog();
				dialogResult = (bool)main.DialogResult; 
			}
			Environment.Exit(0);
		}
	}
}
