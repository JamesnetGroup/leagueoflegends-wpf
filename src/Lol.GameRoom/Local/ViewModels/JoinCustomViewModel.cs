using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Foundation.Mvvm;
using System;
using System.Collections.Generic;

namespace Lol.GameRoom.Local.ViewModels
{
    public class JoinCustomViewModel : ObservableObject
    {
        #region Variables

        private Action<object> _customConfirm;
        public List<LobbyLists> LobbyLists { get; set; }
        #endregion

        #region ICommand
        public RelayCommand<object> ConfirmCommand { get; set; }
        #endregion

        #region Constructor

        public JoinCustomViewModel(Action<object> customConfirm)
        {
            _customConfirm = customConfirm;
            LobbyLists = new GameRoomApi().GetLobbyLists();

            ConfirmCommand = new RelayCommand<object>(RoomCreateCommand, CanRoomCreateCommand);
        }
        #endregion


        #region RoomCreateCommand

        private void RoomCreateCommand(object obj)
        {
            _customConfirm.Invoke(obj);
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
