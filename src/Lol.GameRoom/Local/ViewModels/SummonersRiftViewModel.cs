using Lol.Foundation.Mvvm;
using Lol.YamlDatabase.Collection;

namespace Lol.GameRoom.Local.ViewModels
{
    public class SummonersRiftViewModel : ObservableObject
    {
        private FriendsCollection _friends;

        #region Friends

        public FriendsCollection Friends
        {
            get => _friends;
            set { _friends = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public SummonersRiftViewModel(FriendsCollection friends)
        {
            Friends = friends;
        }
        #endregion
    }
}
