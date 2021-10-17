using Lol.Foundation.Mvvm;
using Lol.YamlDatabase.Controller;
using Lol.YamlDatabase.Entites.Schema;
using System.Collections.Generic;

namespace Lol.Loot.Local.ViewModels
{
    public class LootViewModel : ObservableObject
    {
        #region Variables

        private List<Loots> _menus;
        #endregion

        #region Menus

        public List<Loots> Menus
        {
            get { return _menus; }
            set { _menus = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public LootViewModel()
        {
            Menus = new LootApi().GetLoots();
        }
        #endregion
    }
}
