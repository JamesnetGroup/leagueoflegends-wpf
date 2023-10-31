using Lol.GameRoom.Local.Models;
using Lol.Database.Collection;
using Lol.Database.Entites.Schema;
using System.Collections.Generic;
using System.Linq;
using DevNcore.UI.Foundation.Mvvm;
using Lol.Support.Local.Helpers;

namespace Lol.GameRoom.Local.ViewModels
{
    public class SummonersRiftViewModel : ObservableObject
    {
        private List<MyFriends> _friends;
        private List<GuestModel> _guests;
        private readonly MenuService _menuService;
        private int _guestCount;

        public RelayCommand<object> ModeChangeCommand { get; set; }
        public RelayCommand<object> CloseCommand { get; set; }

        public List<MyFriends> Friends
        {
            get => _friends;
            set { _friends = value; OnPropertyChanged(); }
        }

        public List<GuestModel> Guests
        {
            get => _guests;
            set { _guests = value; OnPropertyChanged(); }
        }

        public int GuestCount
        {
            get => _guestCount;
            set { _guestCount = value; OnPropertyChanged(); }
        }

        public SummonersRiftViewModel(FriendsService friendsService, MenuService menuService)
        {
            _menuService = menuService;

            CloseCommand = new RelayCommand<object>(CloseRoom);
            ModeChangeCommand = new RelayCommand<object>(ChangeMode);

            var friends = (FriendsCollection)friendsService.GetFriends();
            Friends = friends.GeneralList.Children.Where(x => x.Status == 3).ToList();

            List<GuestModel> source = new()
            {
                new GuestModel { Name = "Jamesnet214" }
            };

            Guests = source;
            GuestCount = Guests.Count;
        }


        private void CloseRoom(object obj)
        {
            _menuService.GoHome();
        }


        private void ChangeMode(object obj)
        {
            _menuService.ModeChange();
        }
    }
}
