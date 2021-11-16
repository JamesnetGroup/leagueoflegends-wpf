using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace Lol.Store.Local.ViewModels
{
    public class SkinViewModel : ObservableObject
    {
        #region Variables

        private List<StoreSkinTypes> _skinMenus;
        private StoreSkinTypes _currentSkinMenu;
        #endregion

        #region SkinMenus

        public List<StoreSkinTypes> SkinMenus
        {
            get { return _skinMenus; }
            set { _skinMenus = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentSkinMenu

        public StoreSkinTypes CurrentSkinMenu
        {
            get { return _currentSkinMenu; }
            set { _currentSkinMenu = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public SkinViewModel()
        {
            SkinMenus = new StoreApi().GetSkinCategory();
            CurrentSkinMenu = SkinMenus.First();
        }
        #endregion
    }
}
