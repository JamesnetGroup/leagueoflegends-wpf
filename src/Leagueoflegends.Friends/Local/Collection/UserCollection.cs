using Leagueoflegends.Data.Main;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leagueoflegends.Friends.Local.Collection
{
	public class UserCollection 
	{
		#region SentList

		public ObservableCollection<AddUserModel> SentList { get; set; }
		#endregion

		#region RcentList

		public ObservableCollection<AddUserModel> RecentList { get; set; }
		#endregion

		#region Constructor

		public UserCollection()
		{ 
		
		}
		#endregion

		// Internal..

		#region AddRange 

		internal void AddRange(List<AddUserModel> users)
		{
			SentList = new(users.Where(x => x.IsSent));
			RecentList = new(users.Where(x => x.IsSent == false));
		}
		#endregion

		#region SentDelete

		internal void SentDelete(AddUserModel user)
		{
			RemoveSentList(user);
		}
		#endregion

		#region SentRequest

		internal void SentRequest(AddUserModel user)
		{
			RemoveRecentList(user);
			AddSentList(user);
		}
		#endregion

		// Private..

		#region AddSentList

		private void AddSentList(AddUserModel user)
		{
			user.IsSent = true;
			SentList.Add(user);
		}
		#endregion

		#region RemoveRecentList

		private void RemoveRecentList(AddUserModel user)
		{
			RecentList.Remove(user);
		}
		#endregion

		#region RemoveSentList

		private void RemoveSentList(AddUserModel user)
		{
			SentList.Remove(user);
		}
		#endregion
	}
}
