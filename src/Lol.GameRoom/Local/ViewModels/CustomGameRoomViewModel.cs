using DevNcore.UI.Foundation.Mvvm;
using Lol.Database.Collection;
using Lol.Database.Entites.Schema;
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

        #region Constructor

        public CustomGameRoomViewModel(FriendsCollection friends, Action riftClose, Action modeChange)
        {
            _riftClose = riftClose;
            _modeChange = modeChange;

            CloseCommand = new RelayCommand<object>(CloseRoom);
            ModeChangeCommand = new RelayCommand<object>(ChangeMode);
        }
        #endregion

        #region CloseRoom

        private void CloseRoom(object obj)
        {
            _riftClose?.Invoke();
        }
        #endregion

        #region ChangeMode

        private void ChangeMode(object obj)
        {
            _modeChange?.Invoke();
        }
        #endregion
    }
}
