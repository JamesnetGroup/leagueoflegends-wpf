using System;
using System.Collections.Generic;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using DevNcore.UI.Foundation.Mvvm;
using Jamesnet.Wpf.Mvvm;
using Lol.Support.Local.Helpers;

namespace Lol.GameRoom.Local.ViewModels
{
    public class PVPViewModel : ObservableBase
    {
        private Action<object> _pvpConfirm;
        private GameRooms _currentPVP;
        private readonly MenuService _menuService;

        public List<GameRooms> PVPs { get; set; }

        public RelayCommand<object> ConfirmCommand { get; set; }


        public GameRooms CurrentPVP
        {
            get => _currentPVP;
            set { _currentPVP = value; OnPropertyChanged(); }
        }

        public PVPViewModel(MenuService menuService)
        {
            _menuService = menuService;
            PVPs = new GameRoomApi().GetGameRooms();
            CurrentPVP = PVPs[0];
            ConfirmCommand = new RelayCommand<object>(CreateRoom);
        }

        private void CreateRoom(object obj)
        {
            _menuService.ChangeMenu(33);
        }
    }
}
