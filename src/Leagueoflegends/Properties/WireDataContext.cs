using Jamesnet.Wpf.Global.Location;
using Lol.Forms.Local.ViewModels;
using Lol.Forms.UI.Views;
using Lol.GameRoom.Local.ViewModels;
using Lol.GameRoom.UI.Views;
using Lol.Main.Local.ViewModels;
using Lol.Main.UI.Views;
using Lol.Profile.Local.ViewModels;
using Lol.Profile.UI.Views;

namespace Leagueoflegends.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<HistoryView, HistoryViewModel>();
            items.Register<PVPView, PVPViewModel>();
            items.Register<RiotWindow, RiotViewModel>();
            items.Register<MainContent, MainContentViewModel>();
        }
    }
}
