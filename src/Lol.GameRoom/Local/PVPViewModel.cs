using Lol.Data.GameRoom;
using Lol.ExampleData.GameRoom;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;

namespace Lol.GameRoom.Local
{
    public class PVPViewModel : ObservableObject
    {
        private GameRoomModel _currentPVP;
        public List<GameRoomModel> PVPs { get; set; }
        public GameRoomModel CurrentPVP
        {
            get { return _currentPVP; }
            set { _currentPVP = value; OnPropertyChanged(); }
        }

        public PVPViewModel()
        {
            PVPs = ExamGameRoom.GetGameRoom();
            CurrentPVP = PVPs[0];
        }
    }
}
