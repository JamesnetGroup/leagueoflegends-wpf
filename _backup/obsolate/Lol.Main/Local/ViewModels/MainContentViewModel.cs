using System.Windows.Controls;
using System.Collections.Generic;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Database.Collection;
using Jamesnet.Wpf.Mvvm;
using Jamesnet.Wpf.Controls;
using Lol.Main.UI.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using Lol.Support.Local.Models;
using Lol.Support.Local.Helpers;
using Prism.Ioc;
using System.Windows.Media.Imaging;
using Prism.Regions;

namespace Lol.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableBase, IViewLoadable
    {
        private readonly MenuService _menuService;
        private readonly FriendsService _friendsService;
        private readonly IContainerProvider _containerProvider;
        private readonly IRegionManager _regionManager;
        private Image BackgroundImage;

        [ObservableProperty]
        private int _currentSeq;
        [ObservableProperty]
        private FriendsCollection _friends;

        public MainContentViewModel(FriendsService friendsService, MenuService menuService, IContainerProvider containerProvider, IRegionManager regionManager)
        {
            _menuService = menuService;
            _friendsService = friendsService;
            _containerProvider = containerProvider;
            _regionManager = regionManager;
            _menuService.BackgroundChanged += _menuService_BackgroundChanged;
            _menuService.MenuChanged += _menuService_MenuChanged;
            _menuService.UpdateChanged += _menuService_UpdateChanged;

            List<IFriendsList> friends = new FriendsApi().GetMyFriends(0);
            Friends = new(friends);

            friendsService.SetFriends(Friends);
        }

        private void _menuService_UpdateChanged(object sender, BackgroundChangedEventArgs e)
        {
            CurrentSeq = e.Seq;
        }

        private void _menuService_MenuChanged(object sender, MenuChangedEventArgs e)
        {
            CurrentSeq = e.MenuId;
        }

        public void OnLoaded(IViewable view)
        {
            if (view is MainContent win)
            {
                BackgroundImage = win.BackgroundImage;
            }

            IViewable menuContent = _containerProvider.Resolve<IViewable>("MenuContent");
            IRegion region = _regionManager.Regions["MenuRegion"];
            if (!region.Views.Contains(menuContent))
            {
                region.Add(menuContent);
            }
            region.Activate(menuContent);
        }

        private void _menuService_BackgroundChanged(object sender, BackgroundChangedEventArgs e)
        {
            BackgroundImage.Source = new BitmapImage(e.NewUri);
        }
    }
}