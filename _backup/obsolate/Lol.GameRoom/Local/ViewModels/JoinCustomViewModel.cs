using System;
using System.Collections.Generic;
using DevNcore.UI.Foundation.Mvvm;
using Jamesnet.Wpf.Mvvm;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Support.Local.Helpers;

namespace Lol.GameRoom.Local.ViewModels
{
    public class JoinCustomViewModel : ObservableBase
    {
        private Action<object> _joinGame;
        private readonly MenuService _menuService;

        public List<LobbyList> LobbyList { get; set; }

        public RelayCommand<object> JoinCommand { get; set; }

        public JoinCustomViewModel(MenuService menuService)
        {
            _menuService = menuService;
            LobbyList = new GameRoomApi().GetLobbyList();

            JoinCommand = new RelayCommand<object>(CreateRoom);
        }

        private void CreateRoom(object obj)
        {
            _menuService.ChangeMenu(34);
        }
    }
}
