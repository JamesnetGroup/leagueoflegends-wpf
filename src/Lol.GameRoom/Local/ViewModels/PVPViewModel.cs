using System;
using System.Collections.Generic;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using DevNcore.UI.Foundation.Mvvm;

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
            get => _currentPVP;
            set { _currentPVP = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public PVPViewModel(Action<object> pvpConfirm)
        {
            _pvpConfirm = pvpConfirm;
            PVPs = new GameRoomApi().GetGameRooms();
            CurrentPVP = PVPs[0];
            ConfirmCommand = new RelayCommand<object>(CreateRoom);
        }
        #endregion

        #region CreateRoom

        private void CreateRoom(object obj)
        {
            _pvpConfirm.Invoke(obj);
        }
        #endregion
    }
}
