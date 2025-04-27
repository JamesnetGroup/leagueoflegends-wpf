using Jamesnet.Foundation;
using Leagueoflegends.Main.UI.Views;
using Leagueoflegends.Social.UI.Views;
using Leagueoflegends.Tft.UI.Views;
using Leagueoflegends.Social.Local.ViewModels;
using Leagueoflegends.Home.UI.Views;
using Leagueoflegends.Home.Local.ViewModels;
using Leagueoflegends.Tft.Local.ViewModels;
using Leagueoflegends.Navigate.Local.ViewModels;
using Leagueoflegends.Navigate.UI.Views;
using Leagueoflegends.Support.Local.Services;
using Leagueoflegends.Navigate.Local.Services;
using Leagueoflegends.Main.Local.ViewModels;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Social.Local.Datas;
using Leagueoflegends.Navigate.Local.Datas;
using Leagueoflegends.Tft.Local.Datas;
using Leagueoflegends.Clash.Local.Datas;
using Leagueoflegends.Clash.UI.Views;
using Leagueoflegends.Clash.Local.ViewModels;
using Leagueoflegends.Collection.UI.Views;
using Leagueoflegends.Collection.Local.ViewModels;
using Leagueoflegends.Collection.Local.Datas;
using Leagueoflegends.Store.UI.Views;
using Leagueoflegends.Store.Local.Datas;
using Leagueoflegends.Profile.Local.ViewModels;
using Leagueoflegends.Profile.UI.Views;
using Leagueoflegends.Profile.Local.Datas;
using Leagueoflegends.Shop.UI.Views;
namespace Leagueoflegends;

public class LeagueOfLegendsBootstrapper : AppBootstrapper
{
    protected override void RegisterViewModels(IViewModelMapper viewModelMapper)
    {
        viewModelMapper.Register<MainContent, MainContentViewModel>();
        viewModelMapper.Register<OptionContent, OptionContentViewModel>();
        viewModelMapper.Register<SocialContent, SocialContentViewModel>();
        viewModelMapper.Register<OverviewContent, OverviewContentViewModel>();
        viewModelMapper.Register<SubMenuContent, SubMenuContentViewModel>();
        viewModelMapper.Register<OptionMenuContent, OptionMenuContentViewModel>();

        viewModelMapper.Register<OverviewContent, OverviewContentViewModel>();
        viewModelMapper.Register<ChampionsContent, ChampionsContentViewModel>();
        viewModelMapper.Register<SkinsContent, SkinsContentViewModel>();
        viewModelMapper.Register<SpellsContent, SpellsContentViewModel>();
        viewModelMapper.Register<TftContent, TftContentViewModel>();
        viewModelMapper.Register<HistoryContent, HistoryContentViewModel>();
        viewModelMapper.Register<HubContent, HubContentViewModel>();
        viewModelMapper.Register<StoreChampContent, StoreChampContentViewModel>();
        viewModelMapper.Register<GeneralContent, GeneralContentViewModel>();
        viewModelMapper.Register<VoiceContent, VoiceContentViewModel>();
    }

    protected override void RegisterDependencies(IContainer container)
    {
        Container.RegisterSingleton<IMenuManager, MenuManager>();

        Container.RegisterSingleton<IFriendDataLoader, FriendDataLoader>();
        Container.RegisterSingleton<IMenuDataLoader, MenuDataLoader>();
        Container.RegisterSingleton<IChampStatsDataLoader, ChampStatsDataLoader>();
        Container.RegisterSingleton<IOptionDataLoader, OptionDataLoader>();
        Container.RegisterSingleton<ISkinsDataLoader, SkinsDataLoader>();
        Container.RegisterSingleton<ISpellsDataLoader, SpellsDataLoader>();
        Container.RegisterSingleton<IMatchHistoryDataLoader, MatchHistoryDataLoader>();
        Container.RegisterSingleton<IPlayChampDataLoader, PlayChampDataLoader>();
        Container.RegisterSingleton<IRecentDataLoader, RecentDataLoader>();
        Container.RegisterSingleton<IScheduleDataLoader, ScheduleDataLoader>();
        Container.RegisterSingleton<ITeamFightsDataLoader, TeamFightsDataLoader>();
        Container.RegisterSingleton<IStoreChampDataLoader, StoreChampDataLoader>();

        Container.RegisterSingleton<IView, MainContent>();
        Container.RegisterSingleton<IView, SubMenuContent>();
        Container.RegisterSingleton<IView, OptionMenuContent>();
        Container.RegisterSingleton<IView, SocialContent>();

        Container.RegisterSingleton<IView, OptionContent>("OptionContent");
        Container.RegisterSingleton<IView, TftContent>("TftContent");
        Container.RegisterSingleton<IView, ShopContent>("ShopContent");
        Container.RegisterSingleton<IView, OverviewContent>("HomeOverviewContent");
        Container.RegisterSingleton<IView, HubContent>("ClashHubContent");
        Container.RegisterSingleton<IView, ChampionsContent>("CollectionChampionsContent");
        Container.RegisterSingleton<IView, SkinsContent>("CollectionSkinsContent");
        Container.RegisterSingleton<IView, SpellsContent>("CollectionSpellsContent");
        Container.RegisterSingleton<IView, HistoryContent>("ProfileMatchHistoryContent");
        Container.RegisterSingleton<IView, StoreChampContent>("StoreChampionsContent");
        Container.RegisterSingleton<IView, GeneralContent>("GeneralContent");
        Container.RegisterSingleton<IView, NoticeContent>("NoticeContent");
        Container.RegisterSingleton<IView, ChatContent>("ChatContent");
        Container.RegisterSingleton<IView, SoundContent>("SoundContent");
        Container.RegisterSingleton<IView, VoiceContent>("VoiceContent");
        Container.RegisterSingleton<IView, HotKeyContent>("HotKeyContent");
        Container.RegisterSingleton<IView, VolumeContent>("VolumeContent");
    }

    protected override void SettingsLayer(ILayerManager layer, IContainer container)
    {
        IView mainContent = Container.Resolve<MainContent>();
        IView subNavContent = Container.Resolve<SubMenuContent>();
        IView socialContent = Container.Resolve<SocialContent>();
        IView subMenuContent = Container.Resolve<SubMenuContent>();
        IView optionMenuContent = Container.Resolve<OptionMenuContent>();

        Layer.Mapping("MainLayer", mainContent);
        Layer.Mapping("SubNavLayer", subNavContent);
        Layer.Mapping("SocialLayer", socialContent);
        Layer.Mapping("SubMenuLayer", subMenuContent);
        Layer.Mapping("OptionMenuLayer", optionMenuContent);
    }
}

