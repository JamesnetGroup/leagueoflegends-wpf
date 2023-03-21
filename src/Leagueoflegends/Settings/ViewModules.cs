using Jamesnet.Wpf.Controls;
using LeagueOfLegends.Main.UI.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace LeagueOfLegends.Settings
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IViewable, MainContent>("MainContent");
        }
    }
}
