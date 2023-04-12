using Jamesnet.Wpf.Controls;
using Lol.Main.UI.Views;
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
            containerRegistry.RegisterSingleton<IViewable, MainContent>("MainContent");
        }
    }
}
