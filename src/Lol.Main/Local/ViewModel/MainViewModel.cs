using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Collections.Generic;
using Lol.Data.Main;
using DevNcore.LayoutSupport.Leagueoflegends.Controls;
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
using DevNcore.UI.Foundation.Mvvm;
using DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives;

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
                    18 => new SkinView().SetVM(new SkinsViewModel()),
                    20 => new RuneView().SetVM(new RuneViewModel()),
                    21 => new SpellsView().SetVM(new SpellsViewModel(BackgroundImage)),
                    22 => new ItemView().SetVM(new ItemViewModel()),
                    26 => new store.HomeView().SetVM(new storeVM.HomeViewModel()),
                    // TODO: [Elena] 클래스 이름 중복 관련 임시 처리 
                    27 => new store.ChampionsView().SetVM(new storeVM.ChampionsViewModel()),
                    28 => new store.SkinView().SetVM(new storeVM.SkinViewModel()),
                    29 => new store.TFTView().SetVM(new storeVM.TFTViewModel()),
                    30 => new store.LootView().SetVM(new storeVM.LootViewModel()),
                    31 => new store.EtcView().SetVM(new storeVM.EtcViewModel()),
                    32 => new SummaryView().SetVM(new SummaryViewModel()),
                    33 => new HistoryView().SetVM(new HistoryViewModel()),
                    35 => new HighlightView().SetVM(new HighlightViewModel()),
                    37 => new PVPView().SetVM(new PVPViewModel(PvpConfirm)),
                    40 => new CreateCustomView().SetVM(new CreateCustomViewModel(CreateCustomConfirm)),
                    41 => new JoinCustomView().SetVM(new JoinCustomViewModel(JoinCustomConfirm)),
                    42 => new SummonersRiftView().SetVM(new SummonersRiftViewModel(Friends, GoHome, ModeChange)),
                    43 => new CustomGameRoomView().SetVM(new CustomGameRoomViewModel(Friends, GoHome, ModeChange)),
                    44 => new AvatarView().SetVM(new AvatarViewModel()),
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
        #endregion

        #region OnLoaded

        protected override void OnLoaded(object sender, RoutedEventArgs e)
        {
            if (sender is MainWindow win)
            {
                BackgroundImage = win.BackgroundImage;
            }
        }
        #endregion

        #region PvpConfirm

        private void PvpConfirm(object value)
        {
            // TODO: [Kevin] 게임시작 > 확인 버튼 클릭시 화면 Change, 변경 필히 필요
            SubMenus = null;
            SubMenuChanged(MainMenu.TotalSubMenus[33]);
        }
        #endregion

        #region CustomConfirm

        private void CustomConfirm(object value)
        {
            // TODO: [Lucas] 사용자설정게임 -> 확인 버튼시 게임구성 화면 작업예정
            SubMenus = null;
            SubMenuChanged(MainMenu.TotalSubMenus[34]);
        }
        #endregion

        #region CreateCustomConfirm

        private void CreateCustomConfirm(object value)
        {
            // TODO: [Lucas] 사용자설정게임 -> 확인 버튼시 게임구성 화면 작업예정
            SubMenus = null;
            SubMenuChanged(MainMenu.TotalSubMenus[34]);
        }
        #endregion

        #region JoinCustomConfirm

        private void JoinCustomConfirm(object value)
        {
            // TODO: [Lucas] 사용자설정게임 -> 확인 버튼시 게임구성 화면 작업예정
            SubMenus = null;
            SubMenuChanged(MainMenu.TotalSubMenus[34]);
        }
        #endregion

        #region GoHome: SummonersRiftView "X" 버튼 클릭

        // TODO: [Elena] Menu, Submenu가 제대로 표시되지 않아 수정함
        private void GoHome()
        {
            //SubMenuChanged(MainMenu.TotalSubMenus[0]);
            SubMenus = MainMenu.MenuChangedbyButtonClick(0);
            CurrentSubMenu = SubMenus[0];
        }
        #endregion

        #region ModeChange: SummonersRiftViewModel "모드 변경" 버튼 클릭

        // TODO: [Elena] Menu, Submenu가 제대로 표시되지 않아 수정함
        private void ModeChange()
        {
            //SubMenuChanged(MainMenu.TotalSubMenus[28]);
            SubMenus = MainMenu.MenuChangedbyButtonClick(8);
            CurrentSubMenu = SubMenus[0];
        }
        #endregion
    }
}