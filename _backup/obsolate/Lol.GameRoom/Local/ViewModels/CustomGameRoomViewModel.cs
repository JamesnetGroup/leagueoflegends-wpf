using CommunityToolkit.Mvvm.Input;
using DevNcore.UI.Foundation.Mvvm;
using Lol.Database.Collection;
using Lol.Database.Entites.Schema;
using Lol.Support.Local.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace Lol.GameRoom.Local.ViewModels
{
    public partial class CustomGameRoomViewModel : ObservableObject
    {
        private List<MyFriends> _friends;
        private readonly MenuService _menuService;

        public List<MyFriends> Friends
        {
            get => _friends;
            set { _friends = value; OnPropertyChanged(); }
        }

        public CustomGameRoomViewModel(FriendsService friendsService, MenuService menuService)
        {
            _menuService = menuService;

            var friends = (FriendsCollection)friendsService.GetFriends();
            Friends = friends.GeneralList.Children.Where(x => x.Status == 3).ToList();
        }

        [RelayCommand]
        private void Close()
        {
            _menuService.GoHome();
        }

        [RelayCommand]
        private void ModeChange()
        {
            _menuService.ModeChange();
        }
    }
}
