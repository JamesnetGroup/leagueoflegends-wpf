using Lol.Data.Clash;
using Lol.ExampleData.Clash;
using Lol.Foundation.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Clash.Local.ViewModel
{
	public class WinningTeamViewModel : ObservableObject
    {
        private List<BaseModel> _cups;
        private BaseModel _currentCup;
        private bool _isCup;
        #region Cups

        public List<BaseModel> Cups
        {
            get => _cups;
            set { _cups = value; OnPropertyChanged(); }
        }
        #endregion


        #region IsCup

        public bool IsCup
        {
            get => _isCup;
            set { _isCup = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentCup

        public BaseModel CurrentCup
        {
            get => _currentCup;
            set { _currentCup = value; OnPropertyChanged(); CupChanged(value);  }
        }
        #endregion

        #region Constructor

        public WinningTeamViewModel()
        {
            Cups = ExamClash.GetCup();
            CurrentCup = Cups.First();
        }
        #endregion

        #region CupChanged

        private void CupChanged(BaseModel value)
        {
            IsCup = false;
        }
        #endregion

    }
}
