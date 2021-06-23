using Leagueoflegends.Main.ViewModels;
using Leagueoflegends.Main.Views;
using Leagueoflegends.Windowbase.Riotbase;
using System;
using System.Windows;

namespace Leagueoflegends
{
	public class App : RiotApp
	{
		static MainView main1;

		public App()
		{

		}

		protected override void OnStartup(StartupEventArgs e)
		{
			bool dialogResult = true;

			while (dialogResult)
			{
				ShutdownMode = ShutdownMode.OnExplicitShutdown;
				MainView main = new MainView()
				{
					DataContext = new MainViewModel()
				};


				App.main1 = main;

				_ = main.ShowDialog();
				dialogResult = (bool)main.DialogResult;
			}
			Environment.Exit(0);
		}
	}
}
