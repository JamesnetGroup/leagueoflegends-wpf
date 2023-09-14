using DevNcore.UI.Foundation.Mvvm;
using Jamesnet.Wpf.Mvvm;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Support.Local.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace Lol.GameRoom.Local.ViewModels
{
    public class CreateCustomViewModel : ObservableBase
    {
        private GameRoomsCustom _currentCustom;
        private List<UserCount> _userCount;
        private UserCount _currentUserCount;
        private List<CodeItems> _customGameType;
        private List<CodeItems> _spectatorMode;
        private readonly MenuService _menuService;

        public List<GameRoomsCustom> Customs { get; set; }

        public RelayCommand<object> ConfirmCommand { get; set; }

        public GameRoomsCustom CurrentCustom
        {
            get => _currentCustom;
            set { _currentCustom = value; OnPropertyChanged(); }
        }

        public List<UserCount> UserCount
        {
            get => _userCount;
            set { _userCount = value; OnPropertyChanged(); }
        }

        public UserCount CurrentUserCount
        {
            get => _currentUserCount;
            set { _currentUserCount = value; OnPropertyChanged(); }
        }

        public List<CodeItems> CustomGameType
        {
            get => _customGameType;
            set { _customGameType = value; OnPropertyChanged(); }
        }

        public List<CodeItems> SpectatorMode
        {
            get => _spectatorMode;
            set { _spectatorMode = value; OnPropertyChanged(); }
        }

        public CreateCustomViewModel(MenuService menuService)
        {
            _menuService = menuService;
            Customs = new GameRoomApi().GetGameRoomsCustom();
            CurrentCustom = Customs.FirstOrDefault();

            UserCount = new GameRoomApi().GetUserCount();
            CurrentUserCount = UserCount.LastOrDefault();

            CustomGameType = GetCustomGameType();
            SpectatorMode = GetSpectatorMode();

            ConfirmCommand = new RelayCommand<object>(CreateRoom);
        }

        private void CreateRoom(object obj)
        {
            _menuService.ChangeMenu(34);
        }

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
