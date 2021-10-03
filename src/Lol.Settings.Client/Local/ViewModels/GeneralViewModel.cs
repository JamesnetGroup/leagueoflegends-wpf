using Lol.Data.Codes;
using Lol.Data.Config;
using Lol.Data.Setting;
using Lol.Data.Setting.Clients;
using Lol.Foundation.Mvvm;
using Lol.Foundation.Riotbase;
using Lol.YamlDatabase.Controller;
using Lol.YamlDatabase.Entites.Schema;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;

namespace Lol.Settings.Client.Local.ViewModels
{
    public class GeneralViewModel : ObservableObject
    {
        #region Variables

        private List<Resolutions> _sizeList;
        #endregion

        #region Commands 

        public ICommand LinkCommand { get; set; }
        #endregion

        #region Model

        public GeneralModel Model { get; set; }
        #endregion

        #region SizeList

        public List<Resolutions> SizeList
        {
            get => _sizeList;
            set { _sizeList = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public GeneralViewModel()
        {
            SizeList = new SettingsApi().GetResolutions();

            ConfigModel config = RiotConfig.LoadConfig();
            config.Settings ??= new SettingModel();

            Model = config.Settings.General;

            LinkCommand = new RelayCommand<object>(SearchLink);
        }
        #endregion

        #region SearchLink

        private void SearchLink(object obj)
        {
            string Uri = "https://na.leagueoflegends.com/en-us/event/league-of-legends-code-of-conduct/";

            Process.Start(new ProcessStartInfo(Uri)
            {
                UseShellExecute = true
            });
        }
        #endregion
    }
}
