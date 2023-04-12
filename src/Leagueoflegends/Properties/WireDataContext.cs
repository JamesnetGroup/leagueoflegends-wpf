using Jamesnet.Wpf.Global.Location;
using Lol.Forms.Local.ViewModels;
using Lol.Forms.UI.Views;
using Lol.Main.Local.ViewModel;
using Lol.Main.UI.Views;

namespace Leagueoflegends.Properties
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
