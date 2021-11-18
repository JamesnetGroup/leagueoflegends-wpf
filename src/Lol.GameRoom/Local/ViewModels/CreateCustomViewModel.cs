using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Foundation.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lol.GameRoom.Local.ViewModels
{
    public class CreateCustomViewModel : ObservableObject
    {
        #region Variables

        private Action<object> _customConfirm;
        private GameRoomsCustom _currentCustom;
        private List<UserCount> _userCount;
        private UserCount _currentUserCount;

        public List<GameRoomsCustom> Customs { get; set; }
        #endregion

        #region ICommand

        public RelayCommand<object> ConfirmCommand { get; set; }
        #endregion

        #region CurrentCustom

        public GameRoomsCustom CurrentCustom
        {
            get => _currentCustom;
            set { _currentCustom = value; OnPropertyChanged(); }
        }
        #endregion

        #region UserCount

        public List<UserCount> UserCount
        {
            get => _userCount;
            set { _userCount = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentUserCount

        public UserCount CurrentUserCount
        {
            get => _currentUserCount;
            set { _currentUserCount = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public CreateCustomViewModel(Action<object> customConfirm)
        {
            _customConfirm = customConfirm;
            Customs = new GameRoomApi().GetGameRoomsCustom();

            UserCount = new GameRoomApi().GetUserCount();
            CurrentUserCount = UserCount.LastOrDefault();

            CurrentCustom = Customs.FirstOrDefault();
            ConfirmCommand = new RelayCommand<object>(CreateRoom);
        }
        #endregion

        #region CreateRoom

        private void CreateRoom(object obj)
        {
            _customConfirm.Invoke(obj);
        }
        #endregion
    }
}
