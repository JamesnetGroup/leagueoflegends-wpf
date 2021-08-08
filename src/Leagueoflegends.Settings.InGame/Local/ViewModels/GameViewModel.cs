using Leagueoflegends.Data.Config;
using Leagueoflegends.Data.Setting.InGame;
using Leagueoflegends.DBEntity.Local.Api;
using Leagueoflegends.DBEntity.Local.Entities.Extend;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;
using System.Collections.Generic;

namespace Leagueoflegends.Settings.InGame.Local.ViewModels
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
            CamLockMode = new GetCodeItems().Run("000008");

            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.Game;
        }
        #endregion
    }
}
