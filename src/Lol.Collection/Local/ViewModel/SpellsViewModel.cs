using Lol.Data.Collection;
using Lol.ExampleData.Collection;
using Lol.Foundation.Mvvm;
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
        
        private SpellModel _currentSpell;
        private readonly Image BackgroundImage;
        #endregion

        #region Spells

        public List<SpellModel> Spells { get; set; }
        #endregion

        #region CurrentSpell

        public SpellModel CurrentSpell
        {
            get => _currentSpell;
            set { _currentSpell = value; OnPropertyChanged(); SpellChanged(value); }
        }
        #endregion

        #region Constructor

        public SpellsViewModel(Image backgroundImage)
        {
            BackgroundImage = backgroundImage;
            Spells = ExamSpell.GetSpell();
            CurrentSpell = Spells.First();
        }
        #endregion

        #region SpellChanged

        private void SpellChanged(SpellModel value)
        {
            if (value.Name == "회복")
            {
                // TODO: [Lucas] 임시로 배경화면 변경 부분 처리
                // (전체 구조가 보완되어야 함)
                var uri = new Uri(@"/Lol.Resources;component/Images/leona.jpg", UriKind.RelativeOrAbsolute);
                BackgroundImage.Source = new BitmapImage(uri);
            }
        }
        #endregion
    }
}
