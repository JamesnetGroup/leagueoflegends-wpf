using Jamesnet.Wpf.Global.Location;
using Lol.Clash.Local.ViewModel;
using Lol.Clash.UI.Views;
using Lol.Collection.Local.ViewModel;
using Lol.Collection.UI.Views;
using Lol.Forms.Local.ViewModels;
using Lol.Forms.UI.Views;
using Lol.GameRoom.Local.ViewModels;
using Lol.GameRoom.UI.Views;
using Lol.Home.Local.ViewModels;
using Lol.Home.UI.Views;
using Lol.Main.Local.ViewModels;
using Lol.Main.UI.Views;
using Lol.Profile.Local.ViewModels;
using Lol.Profile.UI.Views;
using Lol.Store.Local.ViewModels;
using Lol.Store.UI.Views;

namespace Leagueoflegends.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<AvatarView, AvatarViewModel>();
            items.Register<HighlightView, HighlightView>();
            items.Register<SummaryView, SummaryViewModel>();
            items.Register<TFTView, TFTViewModel>();
            items.Register<LootView, LootViewModel>();
            items.Register<EtcView, EtcViewModel>();
            items.Register<StoreHomeContent, StoreHomeViewModel>();
            items.Register<StoreChampionsContent, StoreChampionsViewModel>();
            items.Register<StoreSkinContent, StoreSkinViewModel>();
            items.Register<ItemView, ItemViewModel>();
            items.Register<SkinView, SkinsViewModel>();
            items.Register<RuneView, RuneViewModel>();
            items.Register<SpellsView, SpellsViewModel>();
            items.Register<HubView, HubViewModel>();
            items.Register<WinnersView, WinnersViewModel>();
            items.Register<ChampionsView, ChampionsViewModel>();
            items.Register<Overview, OverviewModel>();
            items.Register<CreateCustomView, CreateCustomViewModel>();
            items.Register<JoinCustomView, JoinCustomViewModel>();
            items.Register<HistoryView, HistoryViewModel>();
            items.Register<PVPView, PVPViewModel>();
            items.Register<RiotWindow, RiotViewModel>();
            items.Register<MainContent, MainContentViewModel>();
        }
    }
}
