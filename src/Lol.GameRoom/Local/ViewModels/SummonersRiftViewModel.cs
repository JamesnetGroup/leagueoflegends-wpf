using Lol.Foundation.Mvvm;
using Lol.GameRoom.Local.Models;
using Lol.YamlDatabase.Collection;
using Lol.YamlDatabase.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.GameRoom.Local.ViewModels
{
    public class SummonersRiftViewModel : ObservableObject
    {
        #region Variables

        private List<MyFriends> _friends;
        private List<GuestModel> _guests;
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

        #region Constructor

        public SummonersRiftViewModel(FriendsCollection friends)
        {
            Friends = friends.GeneralList.Children.Where(x => x.Status == 3).ToList();

            List<GuestModel> source = new List<GuestModel>();

            source.Add(new GuestModel { Name = "Elena"});
            Guests = source;
        }
        #endregion
    }
}
