using Leagueoflegends.Data.Config;
using Leagueoflegends.Data.Setting.InGame;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;

namespace Leagueoflegends.Game.Shortcut.Local.ViewModel
{
	public class GameHotKeyViewModel : ObservableObject
	{
		public GameHotKeyModel Model { get; set; }

		#region Constructor
		
		public GameHotKeyViewModel()
		{
			ConfigModel config = RiotConfig.LoadConfig();
			Model = config.Settings.GameHotKey;
		}
		#endregion
	}
}
