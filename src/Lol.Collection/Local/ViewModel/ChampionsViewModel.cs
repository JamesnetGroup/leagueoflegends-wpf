using System.Linq;
using System.Collections.Generic;
using Lol.Foundation.Mvvm;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;

namespace Lol.Collection.Local.ViewModel
{
    public class ChampionsViewModel : ObservableObject
    {
        #region Variables

        private List<ChampFilter> _champFilter1;
        private List<ChampFilter> _champFilter2;

        private ChampFilter _currentChampFilter1;
        private ChampFilter _currentChampFilter2;
        private List<ChampHeaders> _treeSource;
        private string _searchText;
        #endregion

        #region ChampFilter1

        public List<ChampFilter> ChampFilter1
        {
            get => _champFilter1;
            set { _champFilter1 = value; OnPropertyChanged(); }
        }
        #endregion

        #region ChampFilter2

        public List<ChampFilter> ChampFilter2
        {
            get => _champFilter2;
            set { _champFilter2 = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentChampFilter1

        public ChampFilter CurrentChampFilter1
        {
            get => _currentChampFilter1;
            set { _currentChampFilter1 = value; OnPropertyChanged(); FilterChanged(value); }
        }
        #endregion

        #region CurrentChampFilter2

        public ChampFilter CurrentChampFilter2
        {
            get => _currentChampFilter2;
            set { _currentChampFilter2 = value; OnPropertyChanged(); FilterChanged(value); }
        }
        #endregion

        #region TreeSource

        public List<ChampHeaders> TreeSource
        {
            get { return _treeSource; }
            set { _treeSource = value; OnPropertyChanged(); }
        }
        #endregion

        #region SearchText

        public string SearchText
        {
            get { return _searchText; }
            set { _searchText = value; OnPropertyChanged(); SearchTextChanged(value); }
        }
        #endregion

        #region Constructor

        public ChampionsViewModel()
        {
            ChampFilter1 = new ChampApi().GetChampFilter1();
            ChampFilter2 = new ChampApi().GetChampFilter2();

            CurrentChampFilter1 = ChampFilter1.First();
            CurrentChampFilter2 = ChampFilter2.First();

            TreeSource = new ChampApi().GetChampHeaders();
        }
        #endregion

        #region FilterChanged

        private void FilterChanged(ChampFilter value)
        {
            //
        }
        #endregion

        #region SearchTextChanged

        private void SearchTextChanged(string _)
        {
            
        }
        #endregion
    }
}
