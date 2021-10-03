using System.Collections.Generic;
using Lol.Foundation.Mvvm;
using Lol.YamlDatabase.Controller;
using Lol.YamlDatabase.Entites.Schema;

namespace Lol.Profile.Local.ViewModels
{
    public class HistoryViewModel : ObservableObject
    {
        #region Historys

        public List<Historys> Historys { get; set; }
        #endregion

        #region PlayChampions

        public List<Historys> PlayChampions { get; set; }
        #endregion

        #region Activities

        public List<Historys> Activities { get; set; }
        #endregion

        #region Constructor

        public HistoryViewModel()
        {
            Historys = new HistoryApi().GetHistorys();
            Activities = new HistoryApi().GetActivities();
            PlayChampions = new HistoryApi().GetPlayChampions();
        }
        #endregion

    }
}
