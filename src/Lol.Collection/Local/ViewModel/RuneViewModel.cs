using Lol.Foundation.Mvvm;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Lol.Collection.Local.ViewModel
{
    public class RuneViewModel : ObservableObject
    {
        #region Variables 

        private Runes _currentRune;
        private List<RuneDetail> _runeDetail;
        private string _searchText;
        #endregion

        #region Runes

        public List<Runes> Runes { get; set; }
        #endregion

        #region RuneDetail

        public List<RuneDetail> RuneDetail
        {
            get => _runeDetail;
            set { _runeDetail = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentRune

        public Runes CurrentRune
        {
            get => _currentRune;
            set { _currentRune = value; OnPropertyChanged(); RuneChanged(value); }
        }

        #endregion

        #region SearchText

        public string SearchText
        {
            get => _searchText;
            set { _searchText = value; OnPropertyChanged();  RuneTextChanged(value); } 
        }

        #endregion

        #region Constructor

        public RuneViewModel()
        {
            Runes = new RuneApi().GetRunes();
            RuneDetail = new RuneApi().GetRuneDetail();
            _currentRune = Runes.First();
        }
        #endregion

        #region RuneChanged

        private void RuneChanged(Runes value)
        {
            if (value.Seq == 0)
            {
                RuneDetail = new RuneApi().GetRuneDetail();
            }
            else
            {
                RuneDetail = new RuneApi().GetRunesDetail(value.Seq);
            }
        }
        #endregion

        #region RuneTextChanged

        private void RuneTextChanged(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                RuneDetail = new RuneApi().GetRuneDetail();
                return;
            }

            RuneDetail = new RuneApi().GetRuneDetail();
            var list = RuneDetail.Where(x => x.Name.Contains(value));
            RuneDetail = list.ToList();
        }
        #endregion

    }
}
