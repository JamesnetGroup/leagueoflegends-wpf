using Jamesnet.Wpf.Global.Location;
using Lol.Clash.Local.ViewModel;
using Lol.Clash.UI.Views;
using Lol.Collection.Local.ViewModel;
using Lol.Collection.UI.Views;
using Lol.Forms.Local.ViewModels;
using Lol.Forms.UI.Views;
using Lol.Friends.Local.ViewModel;
using Lol.Friends.UI.Views;
using Lol.GameRoom.Local.ViewModels;
using Lol.GameRoom.UI.Views;
using Lol.Home.Local.ViewModels;
using Lol.Home.UI.Views;
using Lol.Loot.Local.ViewModels;
using Lol.Loot.UI.Views;
using Lol.Main.Local.ViewModels;
using Lol.Main.UI.Views;
using Lol.Menus.Local.ViewModels;
using Lol.Menus.UI.Views;
using Lol.MyShop.Local.ViewModel;
using Lol.MyShop.UI.Views;
using Lol.Profile.Local.ViewModels;
using Lol.Profile.UI.Views;
using Lol.Settings.About.Local.ViewModels;
using Lol.Settings.About.UI.Views;
using Lol.Settings.Client.Local.ViewModels;
using Lol.Settings.Client.UI.Views;
using Lol.Settings.InGame.Local.ViewModels;
using Lol.Settings.InGame.UI.Views;
using Lol.Settings.Local.ViewModel;
using Lol.Settings.UI.Views;
using Lol.Store.Local.ViewModels;
using Lol.Store.UI.Views;
using Lol.TeamFight.Local.ViewModel;
using Lol.TeamFight.UI.Views;

namespace Leagueoflegends.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<MenuContent, MenuContentViewModel>();

            items.Register<AddFriendsView, AddFriendsViewModel>();
            
            items.Register<SettingContent, SettingViewModel>();
            items.Register<VerificationContent, VerificationViewModel>();
            items.Register<AlarmContent, AlarmViewModel>();
            items.Register<BlockContent, BlockViewModel>();
            items.Register<ChatContent, ChatViewModel>();
            items.Register<GeneralContent, GeneralViewModel>();
            items.Register<SoundContent, SoundViewModel>();
            items.Register<VoiceContent, VoiceViewModel>();
            items.Register<GameContent, GameSoundViewModel>();
            items.Register<GameSoundContent, GameViewModel>();
            items.Register<HotKeyContent, HotKeyViewModel>();
            items.Register<InterfaceContent, InterfaceViewModel>();
            items.Register<ReplayContent, ReplayViewModel>();
            
            items.Register<TeamFightView, TeamFightViewModel>();
            items.Register<LootView, LootViewModel>();
            items.Register<MyShopView, MyShopViewModel>();
            items.Register<AvatarView, AvatarViewModel>();
            items.Register<HighlightView, HighlightViewModel>();
            items.Register<SummaryView, SummaryViewModel>();
            items.Register<TFTView, TFTViewModel>();
            items.Register<StoreLootView, StoreLootViewModel>();
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
