using Leagueoflegends.Main.ViewModels;
using Leagueoflegends.Main.Views;
using System;
using System.Windows;

namespace Leagueoflegends
{
    public class App : Application
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
                var main = new MainView();
                main.DataContext = new MainViewModel();
                main.ShowDialog();
                dialogResult = (bool)main.DialogResult;
            }
            Environment.Exit(0);
        }
    }
}
