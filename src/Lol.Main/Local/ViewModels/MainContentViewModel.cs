using System;
using System.Linq;
using System.Windows.Controls;
using System.Collections.Generic;
using Lol.Main.Local.Work;
using Lol.Main.UI.Units;
using Lol.MyShop.UI.Views;
using Lol.MyShop.Local.ViewModel;
using Lol.TeamFight.UI.Views;
using Lol.TeamFight.Local.ViewModel;
using Lol.Home.UI.Views;
using Lol.Home.Local.ViewModels;
using Lol.Clash.UI.Views;
using Lol.Clash.Local.ViewModel;
using Lol.Collection.UI.Views;
using Lol.Collection.Local.ViewModel;
using Lol.Profile.UI.Views;
using Lol.Profile.Local.ViewModels;
using store = Lol.Store.UI.Views;
using storeVM = Lol.Store.Local.ViewModels;
using Lol.GameRoom.UI.Views;
using Lol.GameRoom.Local.ViewModels;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Database.Collection;
using Lol.Loot.UI.Views;
using Lol.Loot.Local.ViewModels;
using DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives;
using Jamesnet.Wpf.Mvvm;
using Jamesnet.Wpf.Controls;
using Lol.Main.UI.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Lol.Support.Local.Models;
using Lol.Support.Local.Helpers;
using Prism.Ioc;
using System.Windows.Media.Imaging;

namespace Lol.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableBase, IViewLoadable
    {
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

        private Dictionary<int, object> UIs { get; set; }
        public FriendsSortWork Options { get; }

        [ObservableProperty]
        private List<MainMenuInfo> _menus;
        [ObservableProperty]
        private List<SubMenuInfo> _totalSubMenus;

        [ObservableProperty]
        private MainMenuInfo _currentMenu;
        private readonly MenuService _menuService;
        private readonly IContainerProvider _containerProvider;

        public MainContentViewModel(MenuService menuService, IContainerProvider containerProvider)
        {
            _menuService = menuService;
            _containerProvider = containerProvider;
            Menus = _menuService.GetMenus();
            TotalSubMenus = _menuService.GetSubMenus();

            _menuService.MenuChanged += MenuService_MenuChanged;
            _menuService.BackgroundChanged += _menuService_BackgroundChanged;

            _winWork = new();
            _modalWork = new(this);

            UIs = new();

            Options = new();

            List<IFriendsList> friends = new FriendsApi().GetMyFriends(0);
            Friends = new(friends);
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
                content = value.Seq switch
                {
                    9 or 33 or 37 or 40 or 41 or 12 or 15 or 17 or 18 or 20 or 21 or 22 or 26 or 27 or 28 or 29 or 30 or 31 or 32 or 35 or 44
                        => FindContent(value.ContentName),

                    42 => new SummonersRiftView().SetVM(new SummonersRiftViewModel(Friends, GoHome, ModeChange)),
                    43 => new CustomGameRoomView().SetVM(new CustomGameRoomViewModel(Friends, GoHome, ModeChange)),
                    _ => new EmptyContent()
                };
                // TODO: [Elena] Store의 경우 SubMenu마다 Background가 동일하여 부모Seq로 처리하려고 추가함. 
                ParentSeq = value.MainSeq;
            }
            else
            {
                key = _mainMenu.Seq;
                content = _mainMenu.Seq switch
                {
                    1 => new TeamFightView().SetVM(new TeamFightViewModel()),
                    5 => new LootView().SetVM(new LootViewModel()),
                    6 => new MyShopView().SetVM(new MyShopViewModel()),
                    _ => new EmptyContent()
                };
                ParentSeq = 0;
            }

            if (!UIs.ContainsKey(key))
            {
                UIs.Add(key, content);
            }

            CurrentUI = UIs[key];
            CurrentSeq = key;
        }

        private object FindContent(string name)
        {
            IViewable view = _containerProvider.Resolve<IViewable>(name);
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

        private void GoHome()
        {
            SubMenus = MenuChangedbyButtonClick(0);
            CurrentSubMenu = SubMenus[0];
        }

        private void ModeChange()
        {
            SubMenus = MenuChangedbyButtonClick(8);
            CurrentSubMenu = SubMenus[0];
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
            SubMenus = null;
            CurrentSubMenu = TotalSubMenus[e.MenuId];
        }

        private void _menuService_BackgroundChanged(object sender, BackgroundChangedEventArgs e)
        {
            BackgroundImage.Source = new BitmapImage(e.NewUri);
        }
    }
}