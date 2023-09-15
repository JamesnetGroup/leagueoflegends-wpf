using System.Collections.Generic;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Mvvm;
using Lol.Data.Config;
using Lol.Data.Setting;
using Lol.Data.Setting.Clients;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Foundation.Riotbase;

namespace Lol.Settings.Client.Local.ViewModels
{
    public partial class GeneralViewModel : ObservableBase
    {
        [ObservableProperty]
        private List<Resolutions> _sizeList;

        public GeneralModel Model { get; set; }

        public GeneralViewModel()
        {
            SizeList = new SettingsApi().GetResolutions();

            ConfigModel config = RiotConfig.LoadConfig();
            config.Settings ??= new SettingModel();

            Model = config.Settings.General;
        }

        [RelayCommand]
        private void Link(object obj)
        {
            string Uri = "https://na.leagueoflegends.com/en-us/event/league-of-legends-code-of-conduct/";

            Process.Start(new ProcessStartInfo(Uri)
            {
                UseShellExecute = true
            });
        }
    }
}
