using DevNcore.UI.Foundation.Mvvm;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Collection.Local.ViewModel
{
    public class SkinsViewModel : ObservableObject
    {
        #region Variables

        private List<SkinFilter> _skinFilter1;
        private List<SkinFilter> _skinFilter2;

        private SkinFilter _currentSkinFilter1;
        private SkinFilter _currentSkinFilter2;
        private int _skinCount;
        #endregion

        #region SkinCount

        public int SkinCount
        {
            get => _skinCount;
            set { _skinCount = value; OnPropertyChanged(); }
        }
        #endregion

        #region SkinFilter1

        public List<SkinFilter> SkinFilter1
        {
            get => _skinFilter1;
            set { _skinFilter1 = value; OnPropertyChanged(); }
        }
        #endregion

        #region SkinFilter2

        public List<SkinFilter> SkinFilter2
        {
            get => _skinFilter2;
            set { _skinFilter2 = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentSkinFilter1

        public SkinFilter CurrentSkinFilter1
        {
            get => _currentSkinFilter1;
            set { _currentSkinFilter1 = value; OnPropertyChanged(); FilterChanged(value); }
        }
        #endregion

        #region CurrentSkinFilter2

        public SkinFilter CurrentSkinFilter2
        {
            get => _currentSkinFilter2;
            set { _currentSkinFilter2 = value; OnPropertyChanged(); SortChanged(value); }
        }
        #endregion

        #region Constructor

        public SkinsViewModel()
        {
            SkinCount = 105;

            SkinFilter1 = new SkinApi().GetSkinFilter1();
            CurrentSkinFilter1 = SkinFilter1.First();
        }
        #endregion

        private void FilterChanged(SkinFilter value)
        {
            SkinFilter2 = new SkinApi().GetSkinFilter2(value.Seq);
            CurrentSkinFilter2 = SkinFilter2.First();
        }

        private void SortChanged(SkinFilter value)
        {
            //
        }
    }
}
