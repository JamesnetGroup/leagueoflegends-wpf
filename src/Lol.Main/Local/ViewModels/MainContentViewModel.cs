using System;
using System.Linq;
using System.Windows.Controls;
using System.Collections.Generic;
using Lol.Main.Local.Work;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Database.Collection;
using Jamesnet.Wpf.Mvvm;
using Jamesnet.Wpf.Controls;
using Lol.Main.UI.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        private readonly WindowWork _winWork;
        private readonly ModalWork _modalWork;
        private MainMenuInfo _mainMenu;
        private Image BackgroundImage;

        [ObservableProperty]
        private object _modalContent;
        [ObservableProperty]
        private object _currentUI;
        [ObservableProperty]
        private List<SubMenuInfo> _subMenus;
        [ObservableProperty]
        private SubMenuInfo _currentSubMenu;
        [ObservableProperty]
        private FriendsCollection _friends;
        [ObservableProperty]
        private int _currentSeq;
        [ObservableProperty]
        private int _parentSeq;

        public FriendsSortWork Options { get; }

        [ObservableProperty]
        private List<MainMenuInfo> _menus;
        [ObservableProperty]
        private List<SubMenuInfo> _totalSubMenus;
        [ObservableProperty]
        private MainMenuInfo _currentMenu;

        public MainContentViewModel(FriendsService friendsService, MenuService menuService, IContainerProvider containerProvider, IRegionManager regionManager)
        {
            _menuService = menuService;
            _friendsService = friendsService;
            _containerProvider = containerProvider;
            _regionManager = regionManager;
            Menus = _menuService.GetMenus();
            TotalSubMenus = _menuService.GetSubMenus();

            _menuService.MenuChanged += MenuService_MenuChanged;
            _menuService.BackgroundChanged += _menuService_BackgroundChanged;

            _winWork = new();
            _modalWork = new(this);

            Options = new();

            List<IFriendsList> friends = new FriendsApi().GetMyFriends(0);
            Friends = new(friends);

            friendsService.SetFriends(Friends);
        }

        [RelayCommand]
        private void Close(object value)
        {
            _winWork.DoClosing(value);
        }

        [RelayCommand]
        private void Minimize(object value)
        {
            _winWork.DoMinizing(value);
        }

        [RelayCommand]
        private void Modal(Type value)
        {
            _modalWork.SwitchModal(value);
        }

        [RelayCommand]
        private void Game(Type value)
        {
            CurrentMenu = Menus[8];
            MenuSelect(CurrentMenu);
        }

        internal void MenuSelected(MainMenuInfo menu, List<SubMenuInfo> subMenus)
        {
            _mainMenu = menu;
            SubMenus = subMenus;
            CurrentSubMenu = SubMenus.FirstOrDefault();
        }

        partial void OnCurrentSubMenuChanged(SubMenuInfo value)
        {
            object content;
            int key;

            if (value != null)
            {
                key = value.Seq;
                content = FindContent(value.ContentName);
                ParentSeq = value.MainSeq;
            }
            else
            {
                key = _mainMenu.Seq;
                content = FindContent(_mainMenu.ContentName);
                ParentSeq = 0;
            }

            IRegion region = _regionManager.Regions["ContentsRegion"];
            if(!region.Views.Contains(content))
            {
                region.Add(content);
            }
            region.Activate(content);
            CurrentSeq = key;
        }

        private object FindContent(string name)
        {
            IViewable view;
            try
            {
                view = _containerProvider.Resolve<IViewable>(name);
            }
            catch
            {
                view = _containerProvider.Resolve<IViewable>("EmptyContent");
            }
            return view;
        }

        public void OnLoaded(IViewable view)
        {
            if (view is MainContent win)
            {
                BackgroundImage = win.BackgroundImage;
            }

            CurrentMenu = Menus.First();
            MenuSelect(CurrentMenu);
        }

        [RelayCommand]
        internal void MenuSelect(MainMenuInfo obj)
        {
            List<SubMenuInfo> subMenus = TotalSubMenus.Where(x => x.MainSeq == obj.Seq).ToList();
            MenuSelected(obj, subMenus);
        }

        private List<SubMenuInfo> MenuChangedbyButtonClick(int seq)
        {
            CurrentMenu = Menus[seq];
            List<SubMenuInfo> subMenus = TotalSubMenus.Where(x => x.MainSeq == CurrentMenu.Seq).ToList();

            return subMenus;
        }

        private void MenuService_MenuChanged(object sender, MenuChangedEventArgs e)
        {
            if (e.GoHome)
            {
                SubMenus = MenuChangedbyButtonClick(0);
                CurrentSubMenu = SubMenus[0];
            }
            else if (e.ModeChange)
            {
                SubMenus = MenuChangedbyButtonClick(8);
                CurrentSubMenu = SubMenus[0];
            }
            else
            {
                SubMenus = null;
                CurrentSubMenu = TotalSubMenus[e.MenuId];
            }
        }

        private void _menuService_BackgroundChanged(object sender, BackgroundChangedEventArgs e)
        {
            BackgroundImage.Source = new BitmapImage(e.NewUri);
        }
    }
}