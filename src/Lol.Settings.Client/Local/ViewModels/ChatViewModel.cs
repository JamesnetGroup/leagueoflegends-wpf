using Lol.Data.Config;
using Lol.Data.Setting.Clients;
using Lol.Foundation.Mvvm;
using Lol.Foundation.Riotbase;

namespace Lol.Settings.Client.Local.ViewModels
{
    public class ChatViewModel : ObservableObject
    {
        public ChatModel Model { get; set; }

        #region Constructor

        public ChatViewModel()
        {
            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.Chat;
        }
        #endregion
    }
}
