using Leagueoflegends.DBEntity.Local.Entities.Extend;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Leagueoflegends.Friends.Local.Collection
{
	public class FriendsCollection 
	{
		#region SentList

		public ObservableCollection<RequestUsers> SentList { get; set; }
		#endregion

		#region RcentList

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
			SentList = new(users);
			SentList = new(users.Where(x => x.IsSent));
			RecentList = new(users.Where(x => x.IsSent == false));
		}
		#endregion

		#region SentDelete

		internal void SentDelete(RequestUsers user)
		{
			RemoveSentList(user);
		}
		#endregion

		#region SentRequest

		internal void SentRequest(RequestUsers user)
		{
			RemoveRecentList(user);
			AddSentList(user);
		}
		#endregion

		// Private..

		#region AddSentList

		private void AddSentList(RequestUsers user)
		{
			user.IsSent = true;
			SentList.Add(user);
		}
		#endregion

		#region RemoveRecentList

		private void RemoveRecentList(RequestUsers user)
		{
			RecentList.Remove(user);
		}
		#endregion

		#region RemoveSentList

		private void RemoveSentList(RequestUsers user)
		{
			SentList.Remove(user);
		}
		#endregion
	}
}
