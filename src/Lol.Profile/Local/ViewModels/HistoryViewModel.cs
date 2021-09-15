using Lol.Data.History;
using Lol.ExampleData.History;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;

namespace Lol.Profile.Local.ViewModels
{
    public class HistoryViewModel : ObservableObject
    {
        #region Historys

        public List<HistoryModel> Historys { get; set; }
        #endregion

        #region Constructor

        // TODO: [James] 생성자 경고알림 왜뜨는건지...?
        public HistoryViewModel()
        {
            Historys = ExamHistory.GetHistory();
        }
        #endregion

    }
}
