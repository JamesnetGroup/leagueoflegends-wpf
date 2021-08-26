using Lol.Data.Config;
using Lol.Data.Setting.InGame;
using Lol.DBEntity.Local.Api;
using Lol.DBEntity.Local.Entities.Extend;
using Lol.Foundation.Mvvm;
using Lol.Foundation.Riotbase;
using System.Collections.Generic;

namespace Lol.Settings.InGame.Local.ViewModels
{
	public class GameViewModel : ObservableObject
	{
		private List<UsualCodes> _camLockMode;

		public GameModel Model { get; set; }

		#region CamLockMode

		public List<UsualCodes> CamLockMode
		{
			get => _camLockMode;
			set { _camLockMode = value; OnPropertyChanged(); }
		}
		#endregion

		#region Constructor

		public GameViewModel()
		{
			CamLockMode = new GetCodeItems().Run("000008");

			ConfigModel config = RiotConfig.LoadConfig();
			Model = config.Settings.Game;
		}
		#endregion
	}
}
