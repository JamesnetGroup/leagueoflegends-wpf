using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using Jamesnet.Wpf.Mvvm;
using Lol.Support.Local.Helpers;

namespace Lol.Collection.Local.ViewModel
{
    public class SpellsViewModel : ObservableBase
    {
        private Spells _currentSpell;
        private readonly MenuService _menuService;

        public List<Spells> Spells { get; set; }

        public Spells CurrentSpell
        {
            get => _currentSpell;
            set { _currentSpell = value; OnPropertyChanged(); SpellChanged(value); }
        }

        public SpellsViewModel(MenuService menuService)
        {
            Spells = new SpellApi().GetSpells();
            _currentSpell = Spells.First();
            _menuService = menuService;
        }

        private void SpellChanged(Spells value)
        {
            if (value.Name == "회복")
            {
                // TODO: [Lucas] 임시로 배경화면 변경 부분 처리
                // (전체 구조가 보완되어야 함)
                var uri = new Uri(@"/Lol.Resources;component/Images/leona.jpg", UriKind.RelativeOrAbsolute);

                _menuService.ChangeBackground(uri);
            }
        }
    }
}
