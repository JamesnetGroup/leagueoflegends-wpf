using Lol.Data.Clash;
using Lol.ExampleData.Clash;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Clash.Local.ViewModel
{
	public class WinningTeamViewModel : ObservableObject
    {
        private List<BaseModel> _cups;
        private BaseModel _currentCup;

        #region Cups

        public List<BaseModel> Cups
        {
            get => _cups;
            set { _cups = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentCup

        public BaseModel CurrentCup
        {
            get => _currentCup;
            set { _currentCup = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public WinningTeamViewModel()
        {
            Cups = ExamClash.GetCup();
            CurrentCup = Cups.First();
        }
		#endregion
	}
}
