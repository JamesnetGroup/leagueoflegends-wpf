using System.Linq;
using System.Collections.Generic;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using DevNcore.UI.Foundation.Mvvm;

namespace Lol.Loot.Local.ViewModels
{
    public class LootViewModel : ObservableObject
    {
        #region Variables

        private List<Loots> _menus;
        private List<LootItemSortings> _filters;
        private List<PlantHeaders> _treeSource;
        private List<Loots> _summary;

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

        #region Filters

        public List<LootItemSortings> Filters
        {
            get => _filters;
            set { _filters = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentFilter

        public LootItemSortings CurrentFilter
        {
            get => _currentFilter;
            set { _currentFilter = value; OnPropertyChanged(); }
        }
        #endregion

        #region TreeSource

        public List<PlantHeaders> TreeSource
        {
            get => _treeSource;
            set { _treeSource = value; OnPropertyChanged(); }
        }
        #endregion

        #region Summary

        public List<Loots> Summary
        {
            get => _summary;
            set { _summary = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public LootViewModel()
        {
            Menus = new LootApi().GetCategory();
            CurrentMenu = Menus.First();

            Filters = new LootApi().GetFilters();
            CurrentFilter = Filters.First();

            Summary = new LootApi().GetLootSummary();
        }
        #endregion

        #region MenuChanged

        private void MenuChanged(int seq)
        {
            List<PlantHeaders> source = new LootApi().GetPlantHeaders();

            if (seq != 0)
            {
                source = source.Where(x => x.LootSeq == seq).ToList();
            }

            TreeSource = source;
        }
        #endregion
    }
}
