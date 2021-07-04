using Leagueoflegends.Data.Main;
using Leagueoflegends.DBEntity.Local.Entities.Schema;
using Leagueoflegends.Friends.Local.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Leagueoflegends.Friends.Local.Collection
{
	public class FriendsCollection 
	{
		#region SentList

		public ObservableCollection<ReqestFriends> SentList { get; set; }
		#endregion

		#region RcentList

		public ObservableCollection<ReqestFriends> RecentList { get; set; }
		#endregion

		#region Constructor

		public FriendsCollection()
		{ 
		
		}
		#endregion

		// Internal..

		#region AddRange 

		internal void AddRange(List<ReqestFriends> users)
		{
			SentList = new(users);
			SentList = new(users.Where(x => x.IsSent));
			RecentList = new(users.Where(x => x.IsSent == false));
		}
		#endregion

		#region SentDelete

		internal void SentDelete(ReqestFriends user)
		{
			RemoveSentList(user);
		}
		#endregion

		#region SentRequest

		internal void SentRequest(ReqestFriends user)
		{
			RemoveRecentList(user);
			AddSentList(user);
		}
		#endregion

		// Private..

		#region AddSentList

		private void AddSentList(ReqestFriends user)
		{
			user.IsSent = true;
			SentList.Add(user);
		}
		#endregion

		#region RemoveRecentList

		private void RemoveRecentList(ReqestFriends user)
		{
			RecentList.Remove(user);
		}
		#endregion

		#region RemoveSentList

		private void RemoveSentList(ReqestFriends user)
		{
			SentList.Remove(user);
		}
		#endregion
	}
}
