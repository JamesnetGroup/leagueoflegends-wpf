using Leagueoflegends.Data.Config;
using Leagueoflegends.Data.Setting.Game;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;

namespace Leagueoflegends.Game.Shortcut.Local.ViewModel
{
	public class ShortcutViewModel : ObservableObject
	{
		public GameShortcutModel Model { get; set; }

		#region Constructor
		
		public ShortcutViewModel()
		{
			ConfigModel config = RiotConfig.LoadConfig();
			Model = config.Settings.GameShortcut;
		}
		#endregion
	}
}
