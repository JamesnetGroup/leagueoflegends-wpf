using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;
using System.Threading;

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

            Thread thread = new Thread(() =>
            {
                while(true)
                {
                    Thread.Sleep(5000);

                    int index = NewSkins.IndexOf(CurrentSkin);

                    if (index == NewSkins.Count - 1)
                        index = -1;

                    CurrentSkin = NewSkins[index + 1];
                }
            });

            thread.IsBackground = true;
            thread.Start();
        }
        #endregion
    }
}
