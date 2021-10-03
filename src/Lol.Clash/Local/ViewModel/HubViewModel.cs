using System.Linq;
using System.Collections.Generic;
using Lol.Foundation.Mvvm;
using Lol.YamlDatabase.Controller;
using Lol.YamlDatabase.Entites.Schema;

namespace Lol.Clash.Local.ViewModel
{
    public class HubViewModel : ObservableObject
    {
        #region Variables

        private List<ClashTabs> _tabs;
        private ClashTabs _currentTab;
        #endregion

        #region Tabs

        public List<ClashTabs> Tabs
        {
            get => _tabs;
            set { _tabs = value; OnPropertyChanged(); }
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
        }
        #endregion
    }
}
