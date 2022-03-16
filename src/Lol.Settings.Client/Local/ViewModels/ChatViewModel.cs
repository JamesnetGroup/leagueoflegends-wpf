using DevNcore.UI.Foundation.Mvvm;
using Lol.Data.Config;
using Lol.Data.Setting.Clients;
using Lol.Foundation.Riotbase;

namespace Lol.Settings.Client.Local.ViewModels
{
    public class ChatViewModel : ObservableObject
    {
        #region Model

        public ChatModel Model { get; set; }
        #endregion

        #region Constructor

        public ChatViewModel()
        {
            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.Chat;
        }
        #endregion
    }
}
