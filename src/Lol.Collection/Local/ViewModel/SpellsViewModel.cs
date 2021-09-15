using Lol.Data.Collection;
using Lol.ExampleData.Collection;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;

namespace Lol.Collection.Local.ViewModel
{
    public class SpellsViewModel : ObservableObject
    {
        public List<SpellModel> Spells { get; set; }
    

        public SpellsViewModel()
        {
            Spells = ExamSpell.GetSpell();
        }
    }
}
