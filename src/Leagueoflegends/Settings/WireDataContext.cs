using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Global.Location;
using LeagueOfLegends.Forms.Local.ViewModels;
using LeagueOfLegends.Forms.UI.Views;
using LeagueOfLegends.Main.Local.ViewModels;
using LeagueOfLegends.Main.UI.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace LeagueOfLegends.Settings
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<RiotWindow, RiotViewModel>();
            items.Register<MainContent, MainContentViewModel>();
        }
    }
}
