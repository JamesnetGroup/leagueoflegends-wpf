using Lol.Data.Clash;
using Lol.ExampleData.Clash;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Clash.Local.ViewModel
{
	public class HubViewModel : ObservableObject
	{
		#region Variables

		private List<BaseModel> _tabs;
		private BaseModel _currentTab;
		#endregion

		#region Tabs

		public List<BaseModel> Tabs
		{
			get => _tabs;
			set { _tabs = value; OnPropertyChanged(); }
		}
		#endregion

		#region CurrentTab

		public BaseModel CurrentTab
		{
			get => _currentTab;
			set { _currentTab = value; OnPropertyChanged(); }
		}
		#endregion

		#region Constructor

		public HubViewModel()
		{
			Tabs = ExamClash.GetCategory();
			CurrentTab = Tabs.First();
		}
		#endregion
	}
}
