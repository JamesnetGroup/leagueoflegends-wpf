using Lol.Data.GameRoom;
using Lol.ExampleData.GameRoom;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;

namespace Lol.GameRoom.Local
{
    public class PVPViewModel : ObservableObject
    {
        public List<GameRoomModel> PVPs { get; set; }

        public PVPViewModel()
        {
            PVPs = ExamGameRoom.GetGameRoom();
        }
    }
}
