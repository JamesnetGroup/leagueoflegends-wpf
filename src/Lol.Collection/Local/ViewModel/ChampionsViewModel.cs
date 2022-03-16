using System.Linq;
using System.Collections.Generic;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using DevNcore.UI.Foundation.Mvvm;

namespace Lol.Collection.Local.ViewModel
{
    public class ChampionsViewModel : ObservableObject
    {
        #region Variables

        private List<ChampFilter> _champFilter1;
        private List<ChampFilter> _champFilter2;
        private List<ChampTreeItem> _champions;
        private List<Champions> _champs;

        private ChampFilter _currentChampFilter1;
        private ChampFilter _currentChampFilter2;
        private string _searchText;
        private int _proficiency;
        private int _achieve;
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
            set { _currentChampFilter2 = value; OnPropertyChanged(); SortChanged(value); }
        }
        #endregion

        #region TreeSource

        public List<ChampTreeItem> Champions
        {
            get => _champions;
            set { _champions = value; OnPropertyChanged(); }
        }
        #endregion

        #region TreeSourceClone

        public List<ChampTreeItem> ChampionsClone { get; set; }
        #endregion

        public List<Champions> Champs
        {
            get => _champs;
            set { _champs = value; OnPropertyChanged(); }
        }


        #region SearchText

        public string SearchText
        {
            get => _searchText;
            set { _searchText = value; OnPropertyChanged(); SearchTextChanged(value); }
        }
        #endregion

        #region Proficiency

        public int Proficiency
        {
            get { return _proficiency; }
            set { _proficiency = value; OnPropertyChanged(); }
        }
        #endregion

        #region Achieve

        public int Achieve
        {
            get { return _achieve; }
            set { _achieve = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public ChampionsViewModel()
        {
            ChampFilter1 = new ChampApi().GetChampFilter1();
            ChampFilter2 = new ChampApi().GetChampFilter2();

            CurrentChampFilter1 = ChampFilter1.First();
            CurrentChampFilter2 = ChampFilter2.First();

            Champions = new ChampApi().GetChampTreeItem();
            ChampionsClone = Champions;

            Champs = new ChampApi().GetChampData();

            Proficiency = 282;
            Achieve = 343;
        }
        #endregion

        #region FilterChanged

        private void FilterChanged(ChampFilter value)
        {
            

            //if (value.Seq == 0)
            //{
            //    var items = new ChampApi().GetChampData();

            //}
        }
        #endregion

        #region SortChanged

        private void SortChanged(ChampFilter value)
        {
            //
        }
        #endregion

        #region SearchTextChanged

        private void SearchTextChanged(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                Champions = ChampionsClone;
                return;
            }

            var list = new ChampApi().GetChampTreeItem(value);

            if (list[0].Children.Count < 1)
            {
                Champions = null;
                return;
            }
            else
            {
                Champions = list;
            }
        }
        #endregion
    }
}
