using System.Linq;
using System.Collections.Generic;
using DevNcore.UI.Foundation.Mvvm;
using Lol.Data.Main;

namespace Lol.Main.Local.Work
{
    public class FriendsSortWork : ObservableObject
    {
        public List<OptionModel> SortTypes { get; set; }

        private OptionModel _currentSortType;
        public OptionModel CurrentSortType
        {
            get { return _currentSortType; }
            set { _currentSortType = value; OnPropertyChanged(); }
        }

        public FriendsSortWork()
        {
            SortTypes = GetSortTypes();
            CurrentSortType = SortTypes.First();
        }

        private List<OptionModel> GetSortTypes()
        {
            List<OptionModel> source = new()
            {
                new OptionModel { DisplayName = "Sort Alphabetically" },
                new OptionModel { DisplayName = "Sort by Status" }
            };
            return source;
        }
    }
}
