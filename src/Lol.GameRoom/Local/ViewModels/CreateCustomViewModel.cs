using DevNcore.UI.Foundation.Mvvm;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
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
        private List<CodeItems> _customGameType;
        private List<CodeItems> _spectatorMode;

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

        #region CustomGameType

        public List<CodeItems> CustomGameType
        {
            get => _customGameType;
            set { _customGameType = value; OnPropertyChanged(); }
        }
        #endregion

        #region SpectatorMode

        public List<CodeItems> SpectatorMode
        {
            get => _spectatorMode;
            set { _spectatorMode = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public CreateCustomViewModel(Action<object> customConfirm)
        {
            _customConfirm = customConfirm;

            Customs = new GameRoomApi().GetGameRoomsCustom();
            CurrentCustom = Customs.FirstOrDefault();

            UserCount = new GameRoomApi().GetUserCount();
            CurrentUserCount = UserCount.LastOrDefault();

            CustomGameType = GetCustomGameType();
            SpectatorMode = GetSpectatorMode();

            ConfirmCommand = new RelayCommand<object>(CreateRoom);
        }
        #endregion

        #region CreateRoom

        private void CreateRoom(object obj)
        {
            _customConfirm.Invoke(obj);
        }
        #endregion

        // 임시 작업
        private List<CodeItems> GetCustomGameType()
        {
            List<CodeItems> source = new()
            {
                new CodeItems { Seq = 0, ItemName = "비공개 선택" },
                new CodeItems { Seq = 1, ItemName = "교차 선택" },
                new CodeItems { Seq = 2, ItemName = "모두 무작위" },
                new CodeItems { Seq = 3, ItemName = "토너먼트 드래프트" }
            };
            return source;
        }

        private List<CodeItems> GetSpectatorMode()
        {
            List<CodeItems> source = new()
            {
                new CodeItems { Seq = 0, ItemName = "로비 관전자 공개" },
                new CodeItems { Seq = 1, ItemName = "친구 공개" },
                new CodeItems { Seq = 2, ItemName = "전체 공개" },
                new CodeItems { Seq = 3, ItemName = "비공개" }
            };
            return source;
        }

    }
}
