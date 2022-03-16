using Lol.GameRoom.Local.Models;
using Lol.Database.Collection;
using Lol.Database.Entites.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using DevNcore.UI.Foundation.Mvvm;

namespace Lol.GameRoom.Local.ViewModels
{
    public class SummonersRiftViewModel : ObservableObject
    {
        #region Variables

        private List<MyFriends> _friends;
        private List<GuestModel> _guests;
        private Action _riftClose;
        private Action _modeChange;
        private int _guestCount;
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

        #region Guests

        public List<GuestModel> Guests
        {
            get => _guests;
            set { _guests = value; OnPropertyChanged(); }
        }
        #endregion

        #region GuestCount

        public int GuestCount
        {
            get => _guestCount;
            set { _guestCount = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public SummonersRiftViewModel(FriendsCollection friends, Action riftClose, Action modeChange)
        {
            _riftClose = riftClose;
            _modeChange = modeChange;

            CloseCommand = new RelayCommand<object>(CloseRoom);
            ModeChangeCommand = new RelayCommand<object>(ChangeMode);

            Friends = friends.GeneralList.Children.Where(x => x.Status == 3).ToList();

            List<GuestModel> source = new()
            {
                new GuestModel { Name = "Elena" }
            };

            Guests = source;
            GuestCount = Guests.Count;
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
