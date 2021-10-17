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
        private Loots _currentMneu;
        #endregion

        #region Menus

        public List<Loots> Menus
        {
            get { return _menus; }
            set { _menus = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentMenu

        public Loots CurrentMenu
        {
            get { return _currentMneu; }
            set { _currentMneu = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public LootViewModel()
        {
            Menus = new LootApi().GetLoots();
            CurrentMenu = Menus[0];
        }
        #endregion
    }
}
