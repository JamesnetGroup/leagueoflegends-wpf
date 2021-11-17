using Lol.Database.Collection;
using Lol.Database.Entites.Schema;
using Lol.Foundation.Mvvm;
using System;
using System.Collections.Generic;

namespace Lol.GameRoom.Local.ViewModels
{
    public class CustomGameRoomViewModel : ObservableObject
    {
        #region Variables

        private List<MyFriends> _friends;
        private Action _riftClose;
        private Action _modeChange;
        #endregion

        #region ICommand

        public RelayCommand<object> ModeChangeCommand { get; set; }
        public RelayCommand<object> CloseCommand { get; set; }
        #endregion

        #region Friends

        public List<MyFriends> Friends
        {
            get => _friends;
            set { _friends = value; OnPropertyChanged(); }
        }
        #endregion

        public CustomGameRoomViewModel(FriendsCollection friends, Action riftClose, Action modeChange)
        {
            CloseCommand = new RelayCommand<object>(RoomCloseCommand, CanRoomCloseCommand);
            ModeChangeCommand = new RelayCommand<object>(ModeChangeCommandExe, CanModeChangeCommand);

            _riftClose = riftClose;
            _modeChange = modeChange;
        }

        #region RoomCloseCommand

        private void RoomCloseCommand(object obj)
        {
            _riftClose?.Invoke();
        }

        private bool CanRoomCloseCommand(object obj)
        {
            return true;
        }
        #endregion

        #region ModeChangeCommandExe
        
        private void ModeChangeCommandExe(object obj)
        {
            _modeChange?.Invoke();
        }

        private bool CanModeChangeCommand(object obj)
        {
            return true;
        }

        #endregion

    }
}
