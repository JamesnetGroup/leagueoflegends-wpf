using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;

namespace Lol.Forms.Local.ViewModels
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
            IViewable mainView = _containerProvider.Resolve<IViewable>("MainContent");
            IRegion mainRegion = _regionManager.Regions["MainRegion"];

            if (!mainRegion.Views.Contains(mainView))
            {
                mainRegion.Add(mainView);
            }

            mainRegion.Activate(mainView);
        }
    }
}
