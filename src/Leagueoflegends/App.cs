using System.Windows;
using Jamesnet.Wpf.Controls;
using Lol.Forms.UI.Views;

namespace Leagueoflegends
{
    public class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new RiotWindow();
        }
    }
}
