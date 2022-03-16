using DevNcore.UI.Foundation.Mvvm;
using Lol.Data.Config;
using Lol.Data.Setting.Clients;
using Lol.Foundation.Riotbase;

namespace Lol.Settings.Client.Local.ViewModels
{
    public class SoundViewModel : ObservableObject
    {
        #region Model

        public SoundModel Model { get; set; }
        #endregion

        #region Constructor

        public SoundViewModel()
        {
            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.Sound;
        }
        #endregion
    }
}
