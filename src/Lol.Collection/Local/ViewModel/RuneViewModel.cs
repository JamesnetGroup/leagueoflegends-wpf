using Lol.Foundation.Mvvm;
using Lol.YamlDatabase.Controller;
using Lol.YamlDatabase.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Collection.Local.ViewModel
{
    public class RuneViewModel : ObservableObject
    {
        #region Variables 

        private Runes _currentRune;
        private List<RunesDetail> _runesDetail;
        #endregion

        #region Runes

        public List<Runes> Runes { get; set; }
        public List<RunesDetail> RunesDetail
        {
            get => _runesDetail;
            set { _runesDetail = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentRune

        public Runes CurrentRune
        {
            get => _currentRune;
            set { _currentRune = value; OnPropertyChanged(); RuneChanged(value); }
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
            if (value.Seq == 0)
            {
                RunesDetail = new RuneApi().GetRunesDetail();
            }
            else
            {
                RunesDetail = new RuneApi().GetRunesDetail(value.Seq);
            }
        }
        #endregion

        #region RuneDetailChanged

        private void RuneDetailChanged(List<RunesDetail> value)
        {

        }
        #endregion
    }
}
