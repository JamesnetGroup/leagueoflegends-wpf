using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;

namespace Lol.Store.Local.ViewModels
{
    public class HomeViewModel : ObservableObject
    {
        #region Variables

        private List<NewSkins> _newSkins;
        private NewSkins _currentSkin;
        #endregion

        #region NewSkins

        public List<NewSkins> NewSkins
        {
            get { return _newSkins; }
            set { _newSkins = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentSkin

        public NewSkins CurrentSkin
        {
            get { return _currentSkin; }
            set { _currentSkin = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public HomeViewModel()
        {
            NewSkins = new StoreApi().GetNewSkins();
            CurrentSkin = NewSkins[0];
        }
        #endregion
    }
}
