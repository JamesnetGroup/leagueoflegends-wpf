using Leagueoflegends.Data.Config;
using Leagueoflegends.Data.Setting.InGame;
using Leagueoflegends.DBEntity.Local.Api;
using Leagueoflegends.DBEntity.Local.Entities.Extend;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;
using System.Collections.Generic;

namespace Leagueoflegends.Settings.InGame.Local.ViewModels
{
	public class InterfaceViewModel : ObservableObject
	{
		private List<UsualCodes> _names;
		private List<UsualCodes> _times;
		private List<UsualCodes> _emotions;
		private List<UsualCodes> _emotionSizes;
		private List<UsualCodes> _eternalWorks;

		public InterfaceModel Model { get; set; }

		#region Names

		public List<UsualCodes> Names
		{
			get => _names;
			set { _names = value; OnPropertyChanged(); }
		}
		#endregion

		#region Times

		public List<UsualCodes> Times
		{
			get => _times;
			set { _times = value; OnPropertyChanged(); }
		}
		#endregion

		#region Emotions

		public List<UsualCodes> Emotions
		{
			get => _emotions;
			set { _emotions = value; OnPropertyChanged(); }
		}
		#endregion

		#region EmotionSizes

		public List<UsualCodes> EmotionSizes
		{
			get => _emotionSizes;
			set { _emotionSizes = value; OnPropertyChanged(); }
		}
		#endregion

		#region EternalWorks

		public List<UsualCodes> EternalWorks
		{
			get => _eternalWorks;
			set { _eternalWorks = value; OnPropertyChanged(); }
		}
		#endregion

		#region Constructor

		public InterfaceViewModel()
		{
			Names = new GetCodeItems().Run("000003");
			Times = new GetCodeItems().Run("000004");
			Emotions = new GetCodeItems().Run("000005");
			EmotionSizes = new GetCodeItems().Run("000006");
			EternalWorks = new GetCodeItems().Run("000007");

			ConfigModel config = RiotConfig.LoadConfig();
			Model = config.Settings.Interface;
		}
		#endregion
	}
}
