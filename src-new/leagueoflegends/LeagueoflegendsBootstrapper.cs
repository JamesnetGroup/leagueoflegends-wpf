using Jamesnet.Core;
using Leagueoflegends.Main.UI.Views;
using Leagueoflegends.Social.UI.Views;
using Leagueoflegends.Social.Local.ViewModels;
using Leagueoflegends.Navigate.Local.ViewModels;
using Leagueoflegends.Navigate.UI.Views;
using Leagueoflegends.Support.Local.Services;
using Leagueoflegends.Navigate.Local.Services;
using Leagueoflegends.Main.Local.ViewModels;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Social.Local.Datas;
using Leagueoflegends.Navigate.Local.Datas;
using Leagueoflegends.Home.Local.ViewModels;
using Leagueoflegends.Home.UI.Views;
namespace Leagueoflegends;

public class LeagueOfLegendsBootstrapper : AppBootstrapper
{
    protected override void RegisterViewModels()
    {
        ViewModelMapper.Register<MainContent, MainContentViewModel>();
        ViewModelMapper.Register<SocialContent, SocialContentViewModel>();
        ViewModelMapper.Register<OverviewContent, OverviewContentViewModel>();
        //ViewModelMapper.Register<TftContent, TftContentViewModel>();
        ViewModelMapper.Register<SubMenuContent, SubMenuContentViewModel>();
    }

    protected override void RegisterDependencies()
    {
        Container.RegisterSingleton<ISubMenuNavigator, SubMenuNavigator>();
        Container.RegisterSingleton<IFriendDataLoader, FriendDataLoader>();
        Container.RegisterSingleton<ISubMenuDataLoader, SubMenuDataLoader>();
        Container.RegisterSingleton<IView, MainContent>();
        Container.RegisterSingleton<IView, SubMenuContent>("SubNavContent");
        Container.RegisterSingleton<IView, SocialContent>();
        //Container.RegisterSingleton<IView, TftContent>("TftContent");
        Container.RegisterSingleton<IView, OverviewContent>("HomeOverviewContent");
        //Container.RegisterSingleton<IView, ChampionsContent>("CollectionChampionsContent");

        IView mainContent = Container.Resolve<MainContent>();
        IView subNavContent = Container.Resolve<SubMenuContent>();
        IView socialContent = Container.Resolve<SocialContent>();

        Layer.Mapping("MainLayer", mainContent);
        Layer.Mapping("SubNavLayer", subNavContent);
        Layer.Mapping("SocialLayer", socialContent);
    }

    protected override void OnStartup()
    {
    }
}

