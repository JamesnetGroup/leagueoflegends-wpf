using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using System.Collections.Generic;
using System.Linq;
using DevNcore.UI.Foundation.Mvvm;

namespace Lol.TeamFight.Local.ViewModel
{
    public class TeamFightViewModel : ObservableObject
    {
        #region Variables

        private List<TeamFights> _teamFightItem;
        private TeamFights _currentTeamFightItem;
        #endregion

        #region TeamFightItem

        public List<TeamFights> TeamFightItem
        {
            get { return _teamFightItem; }
            set { _teamFightItem = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentTeamFightItem

        public TeamFights CurrentTeamFightItem
        {
            get { return _currentTeamFightItem; }
            set { _currentTeamFightItem = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public TeamFightViewModel()
        {
            TeamFightItem = new TeamFightApi().GetTeamFights();
            CurrentTeamFightItem = TeamFightItem.First();
        }
        #endregion
    }
}
