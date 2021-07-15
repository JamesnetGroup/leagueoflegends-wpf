using Leagueoflegends.Data.Config;
using Leagueoflegends.Data.Setting.InGame;
using Leagueoflegends.DBEntity.Local.Api;
using Leagueoflegends.DBEntity.Local.Entities.Extend;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;
using System.Collections.Generic;

namespace Leagueoflegends.Game.Sound.Local.ViewModel
{
	public class GameSoundViewModel : ObservableObject
	{
		private List<UsualCodes> _musicTheme;

		public GameSoundModel Model { get; set; }

		#region MusicTheme

		public List<UsualCodes> MusicTheme
		{
			get => _musicTheme;
			set { _musicTheme = value; OnPropertyChanged(); }
		}
		#endregion

		#region Constructor

		public GameSoundViewModel()
		{
			MusicTheme = new GetCodeItems().Run("000002");

			ConfigModel config = RiotConfig.LoadConfig();
			Model = config.Settings.GameSound;
		}
		#endregion
	}
}
