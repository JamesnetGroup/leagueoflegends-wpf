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
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App()
                .Run();
        }
    }
}
