using System.Collections.Generic;
using Lol.Data.History;
using Lol.ExampleData.History;
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

        public List<HistoryModel> PlayChampions { get; set; }
        #endregion

        #region Activities

        public List<Historys> Activities { get; set; }
        #endregion

        #region Constructor

        public HistoryViewModel()
        {
            // yaml 변경완료
            Historys = new HistoryApi().GetHistorys();
            Activities = new HistoryApi().GetActivities();

            // TODO: [Kevin] yaml asd
            PlayChampions = ExamHistory.GetPlayChampions();
        }
        #endregion

    }
}
