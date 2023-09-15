using Jamesnet.Wpf.Controls;
using Lol.Clash.UI.Views;
using Lol.Collection.UI.Views;
using Lol.Friends.UI.Views;
using Lol.GameRoom.UI.Views;
using Lol.Home.UI.Views;
using Lol.Loot.UI.Views;
using Lol.Main.UI.Views;
using Lol.Menus.UI.Views;
using Lol.MyShop.UI.Views;
using Lol.Profile.UI.Views;
using Lol.Settings.About.UI.Views;
using Lol.Settings.Client.UI.Views;
using Lol.Settings.InGame.UI.Views;
using Lol.Settings.UI.Views;
using Lol.Store.UI.Views;
using Lol.TeamFight.UI.Views;
using Prism.Ioc;
using Prism.Modularity;
using EmptyContent = Lol.Main.UI.Units.EmptyContent;

namespace Leagueoflegends.Properties
{
    public class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, MenuContent>("MenuContent");
            containerRegistry.RegisterSingleton<IViewable, SettingContent>("SettingContent");
            containerRegistry.RegisterSingleton<IViewable, VerificationContent>("VerificationContent");
            containerRegistry.RegisterSingleton<IViewable, AlarmContent>("AlarmContent");
            containerRegistry.RegisterSingleton<IViewable, BlockContent>("BlockContent");
            containerRegistry.RegisterSingleton<IViewable, ChatContent>("ChatContent");
            containerRegistry.RegisterSingleton<IViewable, GeneralContent>("GeneralContent");
            containerRegistry.RegisterSingleton<IViewable, SoundContent>("SoundContent");
            containerRegistry.RegisterSingleton<IViewable, VoiceContent>("VoiceContent");
            containerRegistry.RegisterSingleton<IViewable, GameContent>("GameContent");
            containerRegistry.RegisterSingleton<IViewable, GameSoundContent>("GameSoundContent");
            containerRegistry.RegisterSingleton<IViewable, HotKeyContent>("HotKeyContent");
            containerRegistry.RegisterSingleton<IViewable, InterfaceContent>("InterfaceContent");
            containerRegistry.RegisterSingleton<IViewable, ReplayContent>("ReplayContent");
            containerRegistry.RegisterSingleton<IViewable, AddFriendsView>("AddFriendsContent");
            containerRegistry.RegisterSingleton<IViewable, TeamFightView>("TeamFightContent");
            containerRegistry.RegisterSingleton<IViewable, LootView>("LootContent");
            containerRegistry.RegisterSingleton<IViewable, MyShopView>("MyShopContent");
            containerRegistry.RegisterSingleton<IViewable, EmptyContent>("EmptyContent");
            containerRegistry.RegisterSingleton<IViewable, SummaryView>("SummaryContent");
            containerRegistry.RegisterSingleton<IViewable, HighlightView>("HighlightContent");
            containerRegistry.RegisterSingleton<IViewable, AvatarView>("AvatarContent");
            containerRegistry.RegisterSingleton<IViewable, TFTView>("TFTContent");
            containerRegistry.RegisterSingleton<IViewable, StoreLootView>("StoreLootContent");
            containerRegistry.RegisterSingleton<IViewable, EtcView>("EtcContent");
            containerRegistry.RegisterSingleton<IViewable, StoreHomeContent>("StoreHomeContent");
            containerRegistry.RegisterSingleton<IViewable, StoreChampionsContent>("StoreChampionsContent");
            containerRegistry.RegisterSingleton<IViewable, StoreSkinContent>("StoreSkinContent");
            containerRegistry.RegisterSingleton<IViewable, ItemView>("ItemContent");
            containerRegistry.RegisterSingleton<IViewable, SkinView>("SkinContent");
            containerRegistry.RegisterSingleton<IViewable, RuneView>("RuneContent");
            containerRegistry.RegisterSingleton<IViewable, SpellsView>("SpellsContent");
            containerRegistry.RegisterSingleton<IViewable, HubView>("HubContent");
            containerRegistry.RegisterSingleton<IViewable, WinnersView>("WinnersContent");
            containerRegistry.RegisterSingleton<IViewable, ChampionsView>("ChampionsContent");
            containerRegistry.RegisterSingleton<IViewable, Overview>("OverViewContent");
            containerRegistry.RegisterSingleton<IViewable, CreateCustomView>("CreateCustomContent");
            containerRegistry.RegisterSingleton<IViewable, JoinCustomView>("JoinCustomContent");
            containerRegistry.RegisterSingleton<IViewable, HistoryView>("HistoryContent");
            containerRegistry.RegisterSingleton<IViewable, PVPView>("PvpContent");
            containerRegistry.RegisterSingleton<IViewable, MainContent>("MainContent");
        }
    }
}
