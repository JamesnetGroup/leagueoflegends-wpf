using System.Linq;
using System.Collections.Generic;
using Lol.Data.Clash;
using Lol.ExampleData.Clash;
using Lol.Foundation.Mvvm;

namespace Lol.Clash.Local.ViewModel
{
	public class WinnersViewModel : ObservableObject
	{
		#region Variables

		private List<BaseModel> _cups;
		private BaseModel _currentCup;

		private List<BaseModel> _timerMenus;
		private BaseModel _currentTierMenu;
		private bool _isCupChanged;
		private int _lastSeq;

		private List<TierDetailModel> _tierDetails;
		#endregion

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

		#region IsCupChanged

		public bool IsCupChanged
		{
			get => _isCupChanged;
			set { _isCupChanged = value; OnPropertyChanged(); }
		}
		#endregion

		#region LastSeq

		public int LastSeq
		{
			get => _lastSeq;
			set { _lastSeq = value; OnPropertyChanged(); }
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

		public WinnersViewModel()
		{
			Cups = ExamClash.GetCup();
			CurrentCup = Cups.First();

			TierMenus = ExamClash.GetTier();
			CurrentTierMenu = TierMenus.First();
		}
		#endregion

		#region CupChanged

		private void CupChanged()
		{
			IsCupChanged = false;
		}
		#endregion

		#region TierMenuChanged

		private void TierMenuChanged(BaseModel value)
		{
			if (value == null)
				return;

			TierDetails = ExamClash.GetTierDetail().Where(x => x.ParentSeq == value.Seq).ToList();
			LastSeq = TierDetails.Any() ? TierDetails.OrderByDescending(x => x.Seq).First().Seq : 0;
		}
		#endregion
	}
}
