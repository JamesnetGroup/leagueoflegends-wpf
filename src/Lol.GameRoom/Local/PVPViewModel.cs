using Lol.Data.GameRoom;
using Lol.ExampleData.GameRoom;
using Lol.Foundation.Mvvm;
using Lol.YamlDatabase.Controller;
using Lol.YamlDatabase.Entites.Schema;
using System.Collections.Generic;

namespace Lol.GameRoom.Local
{
    public class PVPViewModel : ObservableObject
    {
        private GameRooms _currentPVP;
        public List<GameRooms> PVPs { get; set; }

        public GameRooms CurrentPVP
        {
            get { return _currentPVP; }
            set { _currentPVP = value; OnPropertyChanged(); }
        }

        public PVPViewModel()
        {
            PVPs = new GameRoomApi().GetGameRooms();
            _currentPVP = PVPs[0];
        }
    }
}
