using Lol.Data.Config;
using Lol.Data.Setting.InGame;
using Lol.DBEntity.Local.Api;
using Lol.DBEntity.Local.Entities.Extend;
using Lol.Foundation.Mvvm;
using Lol.Foundation.Riotbase;
using System.Collections.Generic;

namespace Lol.Settings.InGame.Local.ViewModels
{
    public class GameSoundViewModel : ObservableObject
    {
        private List<UsualCodes> _musicTheme;

        public GameSoundModel Model { get; set; }

        #region MusicTheme

        public List<UsualCodes> MusicTheme
        {
            get => _musicTheme;
            set { _musicTheme = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public GameSoundViewModel()
        {
            MusicTheme = new GetCodeItems().Run("000002");

            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.GameSound;
        }
        #endregion
    }
}
