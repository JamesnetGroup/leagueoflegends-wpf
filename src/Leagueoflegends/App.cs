using Leagueoflegends.Main.ViewModels;
using Leagueoflegends.Main.Views;
using Leagueoflegends.Windowbase.Riotbase;
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
				Main.Views.MainView main = new()
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
