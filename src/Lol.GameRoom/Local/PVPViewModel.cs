using Lol.Foundation.Mvvm;
using Lol.YamlDatabase.Controller;
using Lol.YamlDatabase.Entites.Schema;
using System;
using System.Collections.Generic;

namespace Lol.GameRoom.Local
{
    public class PVPViewModel : ObservableObject
    {
        public event EventHandler CreateButtonClicked;
        private GameRooms _currentPVP;
        public List<GameRooms> PVPs { get; set; }

        public GameRooms CurrentPVP
        {
            get { return _currentPVP; }
            set { _currentPVP = value; OnPropertyChanged(); }
        }

        public RelayCommand<object> ButtonRoomCreate { get; set; }

        public PVPViewModel()
        {
            PVPs = new GameRoomApi().GetGameRooms();
            _currentPVP = PVPs[0];
            ButtonRoomCreate = new RelayCommand<object>(ButtonRoomCreateCmd, CanButtonRoomCreateCmd);
        }

        private void ButtonRoomCreateCmd(object obj)
        {
            OnCloseButtonClicked(obj);
        }

        private bool CanButtonRoomCreateCmd(object obj)
        {
            return true;
        }

        protected virtual void OnCloseButtonClicked(object obj)
        {
            EventArgs e = new EventArgs();
            CreateButtonClicked?.Invoke(this, e);
        }
    }
}
