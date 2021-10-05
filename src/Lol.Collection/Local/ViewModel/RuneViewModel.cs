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
        #endregion

        #region Runes

        public List<Runes> Runes { get; set; }
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
            _currentRune = Runes.First();

        }
        #endregion

        #region RuneChanged

        private void RuneChanged(Runes value)
        {
            
        }
        #endregion
    }
}
