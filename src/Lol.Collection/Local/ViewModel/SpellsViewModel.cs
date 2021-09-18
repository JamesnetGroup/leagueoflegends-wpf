using Lol.Data.Collection;
using Lol.ExampleData.Collection;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;

namespace Lol.Collection.Local.ViewModel
{
    public class SpellsViewModel : ObservableObject
    {
        #region Variables 
        
        private SpellModel _CurrentSpell;
        #endregion

        #region Spells
        
        public List<SpellModel> Spells { get; set; }
        #endregion

        #region CurrentSpell

        public SpellModel CurrentSpell
        {
            get { return _CurrentSpell; }
            set { _CurrentSpell = value;OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public SpellsViewModel()
        {
            Spells = ExamSpell.GetSpell();
            CurrentSpell = Spells[0];
        }
        #endregion
    }
}
