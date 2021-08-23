using Lol.Data.Clash;
using Lol.ExampleData.Clash;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Clash.Local.ViewModel
{
	public class ClashViewModel : ObservableObject
    {
        private List<CategoryModel> _tabs;
        private CategoryModel _currentTab;

        #region Tabs

        public List<CategoryModel> Tabs
        {
            get => _tabs;
            set { _tabs = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentTab

        public CategoryModel CurrentTab
        {
            get => _currentTab;
            set { _currentTab = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public ClashViewModel()
        {
            Tabs = ExamClash.GetCategory();
            CurrentTab = Tabs.First();
        }
        #endregion
    }
}
