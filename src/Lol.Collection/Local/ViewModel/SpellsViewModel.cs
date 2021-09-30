using Lol.Foundation.Mvvm;
using Lol.YamlDatabase.Controller;
using Lol.YamlDatabase.Entites.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Lol.Collection.Local.ViewModel
{
    public class SpellsViewModel : ObservableObject
    {
        #region Variables 
        
        private Spells _currentSpell;
        private readonly Image _backgroundImage;
        #endregion

        #region Spells

        public List<Spells> Spells { get; set; }
        #endregion

        #region CurrentSpell

        public Spells CurrentSpell
        {
            get => _currentSpell;
            set { _currentSpell = value; OnPropertyChanged(); SpellChanged(value); }
        }
        #endregion

        #region Constructor

        public SpellsViewModel(Image backgroundImage)
        {
            Spells = new SpellApi().GetSpells();
            _currentSpell = Spells.First();
            _backgroundImage = backgroundImage;
            
        }
        #endregion

        #region SpellChanged

        private void SpellChanged(Spells value)
        {
            if (value.Name == "회복")
            {
                // TODO: [Lucas] 임시로 배경화면 변경 부분 처리
                // (전체 구조가 보완되어야 함)
                var uri = new Uri(@"/Lol.Resources;component/Images/leona.jpg", UriKind.RelativeOrAbsolute);
                _backgroundImage.Source = new BitmapImage(uri);
            }
        }
        #endregion
    }
}
