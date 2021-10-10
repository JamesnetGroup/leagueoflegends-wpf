using Lol.Foundation.Mvvm;
using Lol.YamlDatabase.Controller;
using Lol.YamlDatabase.Entites.Schema;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Collection.Local.ViewModel
{
    public class RuneViewModel : ObservableObject
    {
        #region Variables 

        private Runes _currentRune;
        private List<RunesDetail> _currentRuneDetail;
        #endregion

        #region Runes

        public List<Runes> Runes { get; set; }
        public List<RunesDetail> RunesDetail { get; set; }
        #endregion

        #region CurrentRune

        public Runes CurrentRune
        {
            get => _currentRune;
            set { _currentRune = value; OnPropertyChanged(); RuneChanged(value); }
        }
        
        public List<RunesDetail> CurrentRuneDetail
        {
            get => _currentRuneDetail;
            set { _currentRuneDetail = value; OnPropertyChanged(); RuneDetailChanged(value); }
        }
        #endregion

        #region Constructor

        public RuneViewModel()
        {
            Runes = new RuneApi().GetRunes();
            RunesDetail = new RuneApi().GetRunesDetail();
            _currentRune = Runes.First();

        }
        #endregion

        #region RuneChanged

        private void RuneChanged(Runes value)
        {
            int s = value.Seq;

            List<RunesDetail> dd = RunesDetail.Where(x => x.RunType == s.ToString()).ToList();

            RunesDetail = dd;
            OnPropertyChanged();

        }
        #endregion

        #region RuneDetailChanged

        private void RuneDetailChanged(List<RunesDetail> value)
        {

        }
        #endregion
    }
}
