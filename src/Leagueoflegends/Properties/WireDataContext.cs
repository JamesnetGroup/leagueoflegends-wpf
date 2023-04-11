using Jamesnet.Wpf.Global.Location;
using Lol.Main.Local.ViewModel;
using Lol.Main.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leagueoflegends.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<MainView, MainViewModel>();
        }
    }
}
