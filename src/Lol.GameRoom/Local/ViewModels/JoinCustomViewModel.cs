using System;
using System.Collections.Generic;
using DevNcore.UI.Foundation.Mvvm;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;

namespace Lol.GameRoom.Local.ViewModels
{
    public class JoinCustomViewModel : ObservableObject
    {
        private Action<object> _joinGame;
        public List<LobbyList> LobbyList { get; set; }

        public RelayCommand<object> JoinCommand { get; set; }

        public JoinCustomViewModel(Action<object> joinGame)
        {
            _joinGame = joinGame;
            LobbyList = new GameRoomApi().GetLobbyList();

            JoinCommand = new RelayCommand<object>(CreateRoom);
        }

        private void CreateRoom(object obj)
        {
            _joinGame.Invoke(obj);
        }
    }
}
