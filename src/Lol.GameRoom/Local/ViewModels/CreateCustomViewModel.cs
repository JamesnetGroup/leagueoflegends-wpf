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
        private List<UserCounts> _userCounts;
        private UserCounts _currentUserCount;

        public List<GameRoomsCustom> Customs { get; set; }
        #endregion

        #region ICommand

        public RelayCommand<object> ConfirmCommand { get; set; }
        #endregion

        #region CurrentCustom

        public GameRoomsCustom CurrentCustom
        {
            get { return _currentCustom; }
            set { _currentCustom = value; OnPropertyChanged(); }
        }
        #endregion

        #region UserCounts

        public List<UserCounts> UserCount
        {
            get => _userCounts;
            set { _userCounts = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentUserCount

        public UserCounts CurrentUserCount
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

            UserCount = new GameRoomApi().GetUserCounts();
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
