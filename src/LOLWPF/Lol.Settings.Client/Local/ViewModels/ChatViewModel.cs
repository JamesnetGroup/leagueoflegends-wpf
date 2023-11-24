using DevNcore.UI.Foundation.Mvvm;
using Lol.Data.Config;
using Lol.Data.Setting.Clients;
using Lol.Foundation.Riotbase;

namespace Lol.Settings.Client.Local.ViewModels
{
    public partial class ChatViewModel : ObservableObject
    {
        public ChatModel Model { get; set; }

        public ChatViewModel()
        {
            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.Chat;
        }
    }
}
