using DevNcore.UI.Foundation.Mvvm;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using System.Collections.Generic;
using System.Threading;

namespace Lol.Store.Local.ViewModels
{
    public class HomeViewModel : ObservableObject
    {
        #region Variables

        private List<NewSkins> _newSkins;
        private List<SkinSets> _skinSets;
        private List<Popularities> _popularities;
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

        #region SkinSets

        public List<SkinSets> SkinSets
        {
            get { return _skinSets; }
            set { _skinSets = value; OnPropertyChanged(); }
        }
        #endregion

        #region Popularities

        public List<Popularities> Popularities
        {
            get { return _popularities; }
            set { _popularities = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public HomeViewModel()
        {
            StoreApi storeApi = new StoreApi();
            NewSkins = storeApi.GetNewSkins();
            CurrentSkin = NewSkins[0];
            SkinSets = storeApi.GetSkinSets();
            Popularities = storeApi.GetPopularities();

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
