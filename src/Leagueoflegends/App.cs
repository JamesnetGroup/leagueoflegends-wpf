using Jamesnet.Wpf.Controls;
using Lol.Main.Local.ViewModel;
using Lol.Main.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            MainView main = new();
            main.DataContext = new MainViewModel();
            return main;
        }
    }
}
