using Jamesnet.Wpf.Controls;
using LeagueOfLegends.Forms.UI.Views;
using System.Windows;

namespace LeagueOfLegends
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            //bool dialogResult = true;

            //while (dialogResult)
            //{
            //    ShutdownMode = ShutdownMode.OnExplicitShutdown;
            //    MainView main = new();
            //    main.DataContext = new MainViewModel();

            //    dialogResult = (bool)main.ShowDialog();
            //}
            //Environment.Exit(0);

            //MainView main = new();
            //main.DataContext = new MainViewModel();

            RiotWindow window = new();
            return window;
        }
    }
}
