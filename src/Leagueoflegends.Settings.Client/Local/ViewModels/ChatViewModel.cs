using Leagueoflegends.Data.Config;
using Leagueoflegends.Data.Setting.Clients;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;

namespace Leagueoflegends.Settings.Client.Local.ViewModels
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
