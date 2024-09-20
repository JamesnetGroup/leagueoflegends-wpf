using Lol.Data.Config;
using Lol.Data.Setting.InGame;
using Lol.Database.Entites.Schema;
using Lol.Foundation.Riotbase;
using System.Collections.Generic;
using Lol.Database.Controller;
using DevNcore.UI.Foundation.Mvvm;

namespace Lol.Settings.InGame.Local.ViewModels
{
    public class GameViewModel : ObservableObject
    {
        private List<UsualCodes> _camLockMode;

        public GameModel Model { get; set; }

        #region CamLockMode

        public List<UsualCodes> CamLockMode
        {
            get => _camLockMode;
            set { _camLockMode = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public GameViewModel()
        {
            CamLockMode = new CodesApi().GetCodes("000008");

            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.Game;
        }
        #endregion
    }
}
