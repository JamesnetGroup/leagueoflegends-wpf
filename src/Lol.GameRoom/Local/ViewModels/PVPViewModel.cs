using System;
using System.Windows;
using System.Collections.Generic;
using Lol.Foundation.Mvvm;
using Lol.YamlDatabase.Controller;
using Lol.YamlDatabase.Entites.Schema;

namespace Lol.GameRoom.Local.ViewModels
{
    public class PVPViewModel : ObservableObject
    {
        #region Variables

        private Action<object> _pvpConfirm;
        private GameRooms _currentPVP;
        public List<GameRooms> PVPs { get; set; }
        #endregion

        #region ICommand

        public RelayCommand<object> ConfirmCommand { get; set; }
        #endregion

        #region CurrentPVP

        public GameRooms CurrentPVP
        {
            get { return _currentPVP; }
            set { _currentPVP = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public PVPViewModel(Action<object> pvpConfirm)
        {
            _pvpConfirm = pvpConfirm;
            PVPs = new GameRoomApi().GetGameRooms();
            CurrentPVP = PVPs[0];
            ConfirmCommand = new RelayCommand<object>(RoomCreateCommand, CanRoomCreateCommand);
        }
        #endregion

        #region RoomCreateCommand

        private void RoomCreateCommand(object obj)
        {
            _pvpConfirm.Invoke(obj);
        }
        #endregion

        #region CanRoomCreateCommand

        private bool CanRoomCreateCommand(object obj)
        {
            return true;
        }
        #endregion
    }
}
