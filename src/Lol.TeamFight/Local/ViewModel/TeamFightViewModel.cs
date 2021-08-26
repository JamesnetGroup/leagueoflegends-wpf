using Lol.Data.TeamFight;
using Lol.ExampleData.TeamFight;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace Lol.TeamFight.Local.ViewModel
{
	public class TeamFightViewModel : ObservableObject
	{
		private List<TeamFightModel> _teamFightItem;
		private TeamFightModel _currentTeamFightItem;

		#region TeamFightItem

		public List<TeamFightModel> TeamFightItem
		{
			get { return _teamFightItem; }
			set { _teamFightItem = value; OnPropertyChanged(); }
		}
		#endregion

		#region CurrentTeamFightItem

		public TeamFightModel CurrentTeamFightItem
		{
			get { return _currentTeamFightItem; }
			set { _currentTeamFightItem = value; OnPropertyChanged(); }
		}
		#endregion

		#region Constructor

		public TeamFightViewModel()
		{
			TeamFightItem = ExamTeamFight.GetItems();
			CurrentTeamFightItem = TeamFightItem.First();
		}
		#endregion
	}
}
