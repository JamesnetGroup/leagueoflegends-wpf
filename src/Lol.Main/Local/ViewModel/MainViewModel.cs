using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Collections.Generic;
using Lol.Data.Main;
using Lol.Foundation.Mvvm;
using Lol.Foundation.Riotcore;
using Lol.LayoutSupport.Controls;
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
using Lol.YamlDatabase.Controller;
using Lol.YamlDatabase.Entites.Schema;
using Lol.YamlDatabase.Collection;

namespace Lol.Main.Local.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        #region Variables

        private readonly WindowWork _winWork;
        private readonly ModalWork _modalWork;
        private readonly GameWork _gameWork;

        private object _modalContent;
        private IRiotUI _currentUI;
        private List<SubMenuModel> _subMenus;
        private SubMenuModel _currentSubMenu;
        private MainMenuModel _mainMenu;
        private FriendsCollection _friends;
        private int _currentSeq;
        private int _parentSeq;

        private Image BackgroundImage;

        private Dictionary<int, IRiotUI> UIs { get; set; }
        #endregion

        #region ViewModels

        public MenuWork MainMenu { get; }
        public FriendsSortWork Options { get; }
        #endregion

        #region ICommands

        public ICommand ModalCommand { get; }
        public ICommand CloseCommand { get; }
        public ICommand MinimizeCommand { get; }
        public ICommand GameCommand { get; }
        #endregion

        #region ModalContent

        public object ModalContent
        {
            get => _modalContent;
            set { _modalContent = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentUI

        public IRiotUI CurrentUI
        {
            get => _currentUI;
            set { _currentUI = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentSeq

        public int CurrentSeq
        {
            get => _currentSeq;
            set { _currentSeq = value; OnPropertyChanged(); }
        }
        #endregion

        #region ParentSeq

        public int ParentSeq
        {
            get => _parentSeq;
            set { _parentSeq = value; OnPropertyChanged(); }
        }
        #endregion

        #region SubMenus

        public SubMenuModel CurrentSubMenu
        {
            get => _currentSubMenu;
            set { _currentSubMenu = value; OnPropertyChanged(); SubMenuChanged(value); }
        }

        public List<SubMenuModel> SubMenus
        {
            get => _subMenus;
            set { _subMenus = value; OnPropertyChanged(); }
        }
        #endregion

        #region Friends

        public FriendsCollection Friends
        {
            get => _friends;
            set { _friends = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public MainViewModel()
        {
            _winWork = new();
            _modalWork = new(this);
            _gameWork = new(this);

            UIs = new();

            CloseCommand = new RelayCommand<object>(_winWork.DoClosing);
            MinimizeCommand = new RelayCommand<object>(_winWork.DoMinizing);
            ModalCommand = new RelayCommand<Type>(_modalWork.SwitchModal);
            GameCommand = new RelayCommand<Type>(_gameWork.OpenGameRoom);

            MainMenu = new(MenuSelected);
            Options = new();

            List<IFriendsList> friends = new FriendsApi().GetMyFriends(0);
            Friends = new(friends);
        }
        #endregion

        // Private

        #region MenuSelected

        internal void MenuSelected(MainMenuModel menu, List<SubMenuModel> subMenus)
        {
            _mainMenu = menu;
            SubMenus = subMenus;
            CurrentSubMenu = SubMenus.FirstOrDefault();
        }
        #endregion

        #region SubMenuChanged

        private void SubMenuChanged(SubMenuModel value)
        {
            IRiotUI content;
            int key;

            if (value != null)
            {
                key = value.Seq;
                content = value.Seq switch
                {
                    9 => new Overview().SetVM(new OverviewModel()),
                    12 => new HubView().SetVM(new HubViewModel()),
                    15 => new WinnersView().SetVM(new WinnersViewModel()),
                    17 => new ChampionsView().SetVM(new ChampionsViewModel()),
                    20 => new RuneView().SetVM(new RuneViewModel()),
                    21 => new SpellsView().SetVM(new SpellsViewModel(BackgroundImage)),
                    22 => new ItemView().SetVM(new ItemViewModel()),
                    // TODO: [Elena] 클래스 이름 중복 관련 임시 처리 
                    27 => new store.ChampionsView().SetVM(new storeVM.ChampionsViewModel()),
                    33 => new HistoryView().SetVM(new HistoryViewModel()),
                    37 => new PVPView().SetVM(new PVPViewModel(PvpConfirm)),
                    42 => new SummonersRiftView().SetVM(new SummonersRiftViewModel(Friends, GoHome)),
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
        #endregion

        #region OnLoaded

        protected override void OnLoaded(Window window)
        {
            if (window is MainWindow win)
            {
                BackgroundImage = win.BackgroundImage;
            }
        }
        #endregion

        #region PvpConfirm

        private void PvpConfirm(object value)
        {
            // TODO: [Kevin] 게임시작 > 확인 버튼 클릭시 화면 Change, 변경 필히 필요
            SubMenuChanged(MainMenu.TotalSubMenus[33]);
        }
        #endregion

        private void GoHome()
        {
            SubMenuChanged(MainMenu.TotalSubMenus[0]);
        }
    }
}