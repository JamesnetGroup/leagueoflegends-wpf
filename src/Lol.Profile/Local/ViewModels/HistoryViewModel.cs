using System.Collections.Generic;
using Lol.Foundation.Mvvm;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;

namespace Lol.Profile.Local.ViewModels
{
    public class HistoryViewModel : ObservableObject
    {
        #region History

        public List<History> History { get; set; }
        #endregion

        #region PlayChampions

        public List<History> PlayChampions { get; set; }
        #endregion

        #region Activities

        public List<History> Activities { get; set; }
        #endregion

        #region Constructor

        public HistoryViewModel()
        {
            History = new HistoryApi().GetHistory();
            PlayChampions = new HistoryApi().GetPlayChampions();
            Activities = new HistoryApi().GetActivities();
        }
        #endregion
    }
}
