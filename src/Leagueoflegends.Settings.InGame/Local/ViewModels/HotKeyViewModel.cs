using Leagueoflegends.Data.Config;
using Leagueoflegends.Data.Setting.InGame;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;

namespace Leagueoflegends.Settings.InGame.Local.ViewModels
{
	public class HotKeyViewModel : ObservableObject
	{
		public HotKeyModel Model { get; set; }

		#region Constructor
		
		public HotKeyViewModel()
		{
			ConfigModel config = RiotConfig.LoadConfig();
			Model = config.Settings.HotKey;
		}
		#endregion
	}
}
