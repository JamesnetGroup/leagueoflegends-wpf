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

        private List<Champs> _champsLists;
        private List<ChampCb> _champCb1;
        private List<ChampCb> _champCb2;

        private Champs _currentChamp;
        private ChampCb _currentChampCb1;
        private ChampCb _currentChampCb2;
        private List<ChampHeaders> _treeSource;
        private string _searchText;

        #endregion

        #region Champs
        public List<Champs> Champs
        {
            get { return _champsLists; }
            set { _champsLists = value; OnPropertyChanged(); }
        }
        #endregion

        #region ChampCb1

        public List<ChampCb> ChampCb1
        {
            get { return _champCb1; }
            set { _champCb1 = value; OnPropertyChanged(); }
        }
        #endregion

        #region ChampCb2

        public List<ChampCb> ChampCb2
        {
            get { return _champCb2; }
            set { _champCb2 = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentChamp
        public Champs CurrentChamp
        {
            get { return _currentChamp; }
            set { _currentChamp = value; OnPropertyChanged(); }
        }
        #endregion


        #region TreeSource

        public List<ChampHeaders> TreeSource
        {
            get { return _treeSource; }
            set { _treeSource = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentChampCb1

        public ChampCb CurrentChampCb1
        {
            get { return _currentChampCb1; }
            set { _currentChampCb1 = value; OnPropertyChanged(); MenuChanged1(value); }
        }
        #endregion

        #region CurrentChampCb2

        public ChampCb CurrentChampCb2
        {
            get { return _currentChampCb2; }
            set { _currentChampCb2 = value; OnPropertyChanged(); MenuChanged2(value); }
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
            Champs = new ChampApi().GetChamps();
            var source = new List<Champs>();
            source = Champs.OrderBy(x => x.Name).ToList();
            Champs = source;

            ChampCb1 = new ChampApi().GetChampCb1();
            ChampCb2 = new ChampApi().GetChampCb2();

            CurrentChampCb1 = ChampCb1.First();
            CurrentChampCb2 = ChampCb2.First();

            TreeSource = new ChampApi().GetChampHeaders();
        }
        #endregion

        #region MenuChanged1

        private void MenuChanged1(ChampCb value)
        {
            int seq = value.Seq;
            var treeSource = new ChampApi().GetChampHeaders();

            if (seq != 0)
            {
                treeSource = treeSource.Where(x => x.ChampCbSeq == seq).ToList();
            }

            TreeSource = treeSource;
        }
        #endregion


        #region MenuChanged2

        private void MenuChanged2(ChampCb value)
        {
            
        }
        #endregion

        #region SearchTextChanged

        private void SearchTextChanged(string _)
        {
            
        }
        #endregion

        
        public void TestData()
        {
            //var data = new ChampApi().
        }
        
    }
}
