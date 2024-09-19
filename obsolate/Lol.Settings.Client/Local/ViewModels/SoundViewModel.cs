using Jamesnet.Wpf.Mvvm;
using Lol.Data.Config;
using Lol.Data.Setting.Clients;
using Lol.Foundation.Riotbase;

namespace Lol.Settings.Client.Local.ViewModels
{
    public partial class SoundViewModel : ObservableBase
    {
        public SoundModel Model { get; set; }


        public SoundViewModel()
        {
            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.Sound;
        }
    }
}
