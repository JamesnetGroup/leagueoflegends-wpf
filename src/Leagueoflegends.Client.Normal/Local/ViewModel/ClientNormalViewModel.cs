using Leagueoflegends.Data.Codes;
using Leagueoflegends.Data.Config;
using Leagueoflegends.Data.Setting.Clients;
using Leagueoflegends.ExampleData.Setting;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;
using System.Collections.Generic;

namespace Leagueoflegends.Client.Normal.Local.ViewModel
{
	public class ClientNormalViewModel : ObservableObject
    {
        private List<WindowSizeCode> _sizeList;

        public ClientNormalModel Model { get; set; }

        #region SizeList

        public List<WindowSizeCode> SizeList
		{
			get => _sizeList;
			set { _sizeList = value; OnPropertyChanged(); }
		}
		#endregion

		#region Constructor

		public ClientNormalViewModel()
		{
			SizeList = ExamSettings.GetWinSizeList();

			ConfigModel config = RiotConfig.LoadConfig();
			Model = config.Settings.ClientNormal;
        }
        #endregion
    }
}
