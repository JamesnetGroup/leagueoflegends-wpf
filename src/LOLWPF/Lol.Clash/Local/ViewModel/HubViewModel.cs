using System.Linq;
using System.Collections.Generic;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using DevNcore.UI.Foundation.Mvvm;

namespace Lol.Clash.Local.ViewModel
{
    public class HubViewModel : ObservableObject
    {
        #region Variables

        private List<ClashTabs> _tabs;
        private ClashTabs _currentTab;
        private List<ClashSchedules> _schedules;

        #endregion

        #region Tabs

        public List<ClashTabs> Tabs
        {
            get => _tabs;
            set { _tabs = value; OnPropertyChanged(); }
        }
        #endregion

        #region Schedules

        public List<ClashSchedules> Schedules
        {
            get => _schedules;
            set { _schedules = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentTab

        public ClashTabs CurrentTab
        {
            get => _currentTab;
            set { _currentTab = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public HubViewModel()
        {
            Tabs = new ClashCupApi().GetClashTabs();
            CurrentTab = Tabs.First();

            Schedules = new ClashCupApi().GetClashSchedules();
        }
        #endregion
    }
}
