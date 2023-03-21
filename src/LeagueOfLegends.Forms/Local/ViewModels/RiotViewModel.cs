using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using LeagueOfLegends.Core.Names;
using Prism.Ioc;
using Prism.Regions;

namespace LeagueOfLegends.Forms.Local.ViewModels
{
    public class RiotViewModel : ObservableBase, IViewLoadable
    {
        private readonly IContainerProvider _containerProvider;
        private readonly IRegionManager _regionManager;

        public RiotViewModel(IContainerProvider containerProvider, IRegionManager regionManager) 
        {
            _containerProvider = containerProvider;
            _regionManager = regionManager;
        }

        public void OnLoaded(IViewable view)
        {
            IRegion region = _regionManager.Regions[RegionNameManager.MainRegion];
            IViewable mainContent = _containerProvider.Resolve<IViewable>(ContentNameManager.MainContent);

            if(!region.Views.Contains(mainContent)) 
            {
                region.Add(mainContent);
            }
            region.Activate(mainContent);
        }
    }
}
