using Jamesnet.Wpf.Controls;
using Lol.GameRoom.UI.Views;
using Lol.Main.UI.Views;
using Lol.Profile.UI.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace Leagueoflegends.Properties
{
    public class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, HistoryView>("HistoryContent");
            containerRegistry.RegisterSingleton<IViewable, PVPView>("PvpContent");
            containerRegistry.RegisterSingleton<IViewable, MainContent>("MainContent");
        }
    }
}
