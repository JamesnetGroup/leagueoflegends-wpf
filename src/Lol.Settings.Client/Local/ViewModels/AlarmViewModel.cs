using Lol.Data.Config;
using Lol.Data.Setting.Clients;
using Lol.Foundation.Mvvm;
using Lol.Foundation.Riotbase;

namespace Lol.Settings.Client.Local.ViewModels
{
    public class AlarmViewModel : ObservableObject
    {
        public AlarmModel Model { get; set; }

        #region Constructor

        public AlarmViewModel()
        {
            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.Alarm;
        }
        #endregion
    }
}
