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

		private List<BaseModel> _timerMenus;
		private BaseModel _currentTierMenu;
		private bool _isCup;

		private List<TierDetailModel> _tierDetails;

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
			set { _currentCup = value; OnPropertyChanged(); CupChanged(); }
		}
		#endregion

		#region TierMenus

		public List<BaseModel> TierMenus
		{
			get => _timerMenus;
			set { _timerMenus = value; OnPropertyChanged(); }
		}
		#endregion

		#region CurrentTierMenu

		public BaseModel CurrentTierMenu
		{
			get => _currentTierMenu;
			set { _currentTierMenu = value; OnPropertyChanged(); TierMenuChanged(value); }
		}
        #endregion

        #region IsCup

        public bool IsCup
		{
			get => _isCup;
			set { _isCup = value; OnPropertyChanged(); }
		}
		#endregion

		#region TierDetails

		public List<TierDetailModel> TierDetails
		{
			get => _tierDetails;
			set { _tierDetails = value; OnPropertyChanged(); }
		}
		#endregion

		#region Constructor

		public WinningTeamViewModel()
		{
			Cups = ExamClash.GetCup();
			CurrentCup = Cups.First();

			TierMenus = ExamClash.GetTier();
			CurrentTierMenu = TierMenus.First();

			TierDetails = ExamClash.GetTierDetail();
		}
		#endregion

		#region CupChanged

		private void CupChanged()
		{
			IsCup = false;
		}
		#endregion

		private void TierMenuChanged(BaseModel value)
		{
			if (value == null)
				return;

		}

	}
}
