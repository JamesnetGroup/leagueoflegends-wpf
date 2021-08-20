using Lol.Data.Config;
using Lol.Data.Setting.Clients;
using Lol.Foundation.Mvvm;
using Lol.Foundation.Riotbase;

namespace Lol.Settings.Client.Local.ViewModels
{
    public class SoundViewModel : ObservableObject
    {
        public SoundModel Model { get; set; }

        #region Constructor

        public SoundViewModel()
        {
            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.Sound;
        }
        #endregion
    }
}
