using Lol.Foundation.Mvvm;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Loot.Local.ViewModels
{
    public class LootViewModel : ObservableObject
    {
        #region Variables

        private List<Loots> _menus;
        private List<LootItemSortings> _filters;
        private List<PlantHeaders> _treeSource;
        private List<Loots> _items;

        private Loots _currentMenu;
        private LootItemSortings _currentFilter;
        #endregion

        #region Menus

        public List<Loots> Menus
        {
            get => _menus;
            set { _menus = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentMenu

        public Loots CurrentMenu
        {
            get => _currentMenu;
            set { _currentMenu = value; OnPropertyChanged(); MenuChanged(value.Seq); }
        }
        #endregion

        #region TreeSource

        public List<PlantHeaders> TreeSource
        {
            get { return _treeSource; }
            set { _treeSource = value; OnPropertyChanged(); }
        }
        #endregion

        #region Items

        public List<Loots> Items
        {
            get { return _items; }
            set { _items = value; OnPropertyChanged(); }
        }
        #endregion

        #region Filters

        public List<LootItemSortings> Filters
        {
            get { return _filters; }
            set { _filters = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentCbx

        public LootItemSortings CurrentFilter
        {
            get { return _currentFilter; }
            set { _currentFilter = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public LootViewModel()
        {
            Menus = new LootApi().GetCategory();
            CurrentMenu = Menus.First();

            Filters = new LootApi().GetFilters();
            CurrentFilter = Filters.First();

            Items = new LootApi().GetLootItems();
        }
        #endregion

        #region MenuChanged

        private void MenuChanged(int seq)
        {
            var treeSource = new LootApi().GetPlantHeaders();

            if (seq != 0)
                treeSource = treeSource.Where(x => x.LootSeq == seq).ToList();

            TreeSource = treeSource;
        }
        #endregion
    }
}
