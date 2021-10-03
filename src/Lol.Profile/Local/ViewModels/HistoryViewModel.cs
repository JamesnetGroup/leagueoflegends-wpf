using System.Collections.Generic;
using Lol.Foundation.Mvvm;
using Lol.YamlDatabase.Controller;
using Lol.YamlDatabase.Entites.Schema;

namespace Lol.Profile.Local.ViewModels
{
    public class HistoryViewModel : ObservableObject
    {
        #region Historys

        public List<Histories> Historys { get; set; }
        #endregion

        #region PlayChampions

        public List<Histories> PlayChampions { get; set; }
        #endregion

        #region Activities

        public List<Histories> Activities { get; set; }
        #endregion

        #region Constructor

        public HistoryViewModel()
        {
            Historys = new HistoryApi().GetHistories();
            PlayChampions = new HistoryApi().GetPlayChampions();
            Activities = new HistoryApi().GetActivities();
        }
        #endregion

    }
}
