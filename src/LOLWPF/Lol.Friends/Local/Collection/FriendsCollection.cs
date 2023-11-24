using Lol.Database.Entites.Schema;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Lol.Friends.Local.Collection
{
    public class FriendsCollection
    {
        #region RequestList

        public ObservableCollection<RequestUsers> RequestList { get; set; }
        #endregion

        #region RecentList

        public ObservableCollection<RequestUsers> RecentList { get; set; }
        #endregion

        #region Constructor

        public FriendsCollection()
        {

        }
        #endregion

        // Internal..

        #region AddRange 

        internal void AddRange(List<RequestUsers> users)
        {
            RequestList = new(users);
            RequestList = new(users.Where(x => x.IsSent));
            RecentList = new(users.Where(x => x.IsSent == false));
        }
        #endregion

        #region CancelRequest

        internal void CancelRequest(RequestUsers user)
        {
            RemoveRequestList(user);
        }
        #endregion

        #region SendRequest

        internal void SendRequest(RequestUsers user)
        {
            RemoveRecentList(user);
            AddRequestList(user);
        }
        #endregion

        // Private..

        #region AddRequestList

        private void AddRequestList(RequestUsers user)
        {
            user.IsSent = true;
            RequestList.Add(user);
        }
        #endregion

        #region RemoveRecentList

        private void RemoveRecentList(RequestUsers user)
        {
            RecentList.Remove(user);
        }
        #endregion

        #region RemoveRequestList

        private void RemoveRequestList(RequestUsers user)
        {
            RequestList.Remove(user);
        }
        #endregion
    }
}
