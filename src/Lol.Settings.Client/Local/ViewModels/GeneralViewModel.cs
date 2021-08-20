using Lol.Data.Codes;
using Lol.Data.Config;
using Lol.Data.Setting;
using Lol.Data.Setting.Clients;
using Lol.ExampleData.Setting;
using Lol.Foundation.Mvvm;
using Lol.Foundation.Riotbase;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;

namespace Lol.Settings.Client.Local.ViewModels
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
        #endregion

        #region SearchLink

        private void SearchLink(object obj)
        {
            string Uri = "https://na.Lol.com/en-us/event/league-of-legends-code-of-conduct/";

            var process = new Process()
            {
                StartInfo = new ProcessStartInfo(Uri)
            };
            process.Start();
        }
		#endregion
	}
}
