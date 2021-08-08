using Leagueoflegends.Data.Codes;
using Leagueoflegends.Data.Config;
using Leagueoflegends.Data.Setting;
using Leagueoflegends.Data.Setting.Clients;
using Leagueoflegends.ExampleData.Setting;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;

namespace Leagueoflegends.Settings.Client.Local.ViewModels
{
    public class GeneralViewModel : ObservableObject
    {
        private List<WindowSizeCode> _sizeList;

        public ICommand LinkCommand { get; set; }
        
        public GeneralModel Model { get; set; }

        #region SizeList

        public List<WindowSizeCode> SizeList
        {
            get => _sizeList;
            set { _sizeList = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public GeneralViewModel()
        {
            SizeList = ExamSettings.GetWinSizeList();

            ConfigModel config = RiotConfig.LoadConfig();
            config.Settings = config.Settings ?? new SettingModel();

            Model = config.Settings.General;

            LinkCommand = new RelayCommand<object>(SearchLink);
        }

        private void SearchLink(object obj)
        {
            string Uri = "https://na.leagueoflegends.com/en-us/event/league-of-legends-code-of-conduct/";
            
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo(Uri)
            };
            process.Start();
        }
        #endregion
    }
}
