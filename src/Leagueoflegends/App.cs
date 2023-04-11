using System;
using System.Windows;
using Lol.Main.UI.Views;
using Lol.Main.Local.ViewModel;
using DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives;
using Jamesnet.Wpf.Controls;

namespace Leagueoflegends
{
    public class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new MainView();
        }
    }
}
