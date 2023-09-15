using System;
using System.Linq;
using System.Windows.Controls;
using System.Collections.Generic;
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
using System.Windows;
using Lol.Friends.UI.Views;
using Lol.Settings.UI.Views;
using Lol.Data.Main;

namespace Lol.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableBase, IViewLoadable
    {
        private readonly MenuService _menuService;
        private readonly FriendsService _friendsService;
        private readonly IContainerProvider _containerProvider;
        private readonly IRegionManager _regionManager;
        private MainMenuInfo _mainMenu;
        private Image BackgroundImage;

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
        [ObservableProperty]
        private List<OptionModel> _sortTypes;
        [ObservableProperty]
        private OptionModel _currentSortType;
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
            TotalSubMenus = _menuService.GetSubMenus();

            _menuService.MenuChanged += MenuService_MenuChanged;
            _menuService.BackgroundChanged += _menuService_BackgroundChanged;
            _menuService.ModalClosed += _menuService_ModalClosed;

            Menus = _menuService.GetMenus();
            SortTypes = GetSortTypes();
            CurrentSortType = SortTypes.First();

            List<IFriendsList> friends = new FriendsApi().GetMyFriends(0);
            Friends = new(friends);

            friendsService.SetFriends(Friends);
        }

        [RelayCommand]
        private void Close(object value)
        {
            Window.GetWindow((UIElement)value).Close();
        }

        [RelayCommand]
        private void Minimize(object value)
        {
            Window.GetWindow((UIElement)value).WindowState = WindowState.Minimized;
        }

        [RelayCommand]
        private void Modal(Type value)
        {
            SwitchModal(value);
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

        private IViewable FindContent(string name)
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

        private void _menuService_ModalClosed(object sender, EventArgs e)
        {
            IRegion region = _regionManager.Regions["ModalRegion"];

            foreach (var i in region.ActiveViews)
            {
                region.Deactivate(i);
            }
        }

        internal void SwitchModal(Type type)
        {
            string name = "";

            if (typeof(SettingContent) == type) name = "SettingContent";
            if (typeof(AddFriendsView) == type) name = "AddFriendsContent";

            IViewable content = FindContent(name);

            IRegion region = _regionManager.Regions["ModalRegion"];

            if (!region.Views.Contains(content))
            {
                region.Add(content);
            }
            region.Activate(content);
        }

        private List<OptionModel> GetSortTypes()
        {
            List<OptionModel> source = new()
            {
                new OptionModel { DisplayName = "Sort Alphabetically" },
                new OptionModel { DisplayName = "Sort by Status" }
            };
            return source;
        }
    }
}