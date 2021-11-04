using Lol.Foundation.Mvvm;

namespace Lol.Collection.Local.ViewModel
{
    public class SkinsViewModel : ObservableObject
    {
        #region Variables

        private int _skinCount;
        #endregion

        #region SkinCount

        public int SkinCount
        {
            get => _skinCount;
            set { _skinCount = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public SkinsViewModel()
        {
            SkinCount = 105;  // TODO: [Elena] 추후 데이터 수정
        }
        #endregion
    }
}
