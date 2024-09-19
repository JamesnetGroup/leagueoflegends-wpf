using Lol.Support.Local.Helpers;
using Prism.Ioc;
using Prism.Modularity;

namespace Leagueoflegends.Properties
{
    internal class HelperModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<FriendsService>();
            containerRegistry.RegisterSingleton<MenuService>();
        }
    }
}
