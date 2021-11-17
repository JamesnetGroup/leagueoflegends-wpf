using System;
using System.Collections.Generic;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Foundation.Mvvm;


namespace Lol.GameRoom.Local.ViewModels
{
    public class JoinCustomViewModel : ObservableObject
    {
        #region Variables

        private Action<object> _joinGame;
        public List<LobbyList> LobbyList { get; set; }
        #endregion

        #region ICommand

        public RelayCommand<object> JoinCommand { get; set; }
        #endregion

        #region Constructor

        public JoinCustomViewModel(Action<object> joinGame)
        {
            _joinGame = joinGame;
            LobbyList = new GameRoomApi().GetLobbyList();

            JoinCommand = new RelayCommand<object>(CreateRoom);
        }
        #endregion

        #region CreateRoom

        private void CreateRoom(object obj)
        {
            _joinGame.Invoke(obj);
        }
        #endregion
    }
}
