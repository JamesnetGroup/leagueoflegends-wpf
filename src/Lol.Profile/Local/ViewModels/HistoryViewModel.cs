using System.Collections.Generic;
using Lol.Data.History;
using Lol.ExampleData.History;
using Lol.Foundation.Mvvm;

namespace Lol.Profile.Local.ViewModels
{
    public class HistoryViewModel : ObservableObject
    {
        #region Historys

        public List<HistoryModel> Historys { get; set; }
        #endregion

        #region PlayChampions

        public List<HistoryModel> PlayChampions { get; set; }
        #endregion

        #region Activities

        public List<HistoryModel> Activities { get; set; }
        #endregion

        #region Constructor

        public HistoryViewModel()
        {
            Historys = ExamHistory.GetHistory();
            PlayChampions = ExamHistory.GetPlayChampions();
            Activities = ExamHistory.GetActivities();
        }
        #endregion

    }
}
