using Lol.Data.WinningTeam;
using Lol.ExampleData.WinningTeam;
using Lol.Foundation.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.Clash.Local.ViewModel
{
    public class WinningTeamViewModel : ObservableObject
    {
        private List<CupModel> _cups;

        #region Cups

        public List<CupModel> Cups
        {
            get => _cups;
            set { _cups = value; OnPropertyChanged(); }
        }
        #endregion
        public WinningTeamViewModel()
        {
            Cups = ExamWinningTeam.GetCup();
        }
    }
}
