using Lol.Data.Main;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Main.Local.Work
{
    public class FriendsSortWork : ObservableObject
    {
        #region SortTypes

        public List<OptionModel> SortTypes { get; set; }
        #endregion

        #region CurrentSortType

        private OptionModel _currentSortType;
        public OptionModel CurrentSortType
        {
            get { return _currentSortType; }
            set { _currentSortType = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public FriendsSortWork()
        {
            SortTypes = GetSortTypes();
            CurrentSortType = SortTypes.First();
        }
        #endregion

        #region GetSortTypes

        private List<OptionModel> GetSortTypes()
        {
            List<OptionModel> source = new()
            {
                new OptionModel { DisplayName = "Sort Alphabetically" },
                new OptionModel { DisplayName = "Sort by Status" }
            };
            return source;
        }
        #endregion
    }
}
