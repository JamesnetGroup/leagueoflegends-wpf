using DevNcore.UI.Foundation.Mvvm;
using Lol.Data.Config;
using Lol.Data.Setting.InGame;
using Lol.Foundation.Riotbase;

namespace Lol.Settings.InGame.Local.ViewModels
{
    public class HotKeyViewModel : ObservableObject
    {
        public HotKeyModel Model { get; set; }

        #region Constructor

        public HotKeyViewModel()
        {
            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.HotKey;
        }
        #endregion
    }
}
