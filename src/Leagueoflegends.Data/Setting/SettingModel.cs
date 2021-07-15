using Leagueoflegends.Data.Setting.Clients;
using Leagueoflegends.Data.Setting.InGame;

namespace Leagueoflegends.Data.Setting
{
	public class SettingModel
	{ 
		public ClientNormalModel ClientNormal { get; set; }
		public ClientAlarmModel ClientAlarm { get; set; }
		public ClientChatModel ClientChat { get; set; }
		public ClientSoundModel ClientSound { get; set; }
		public ClientVoiceModel ClientVoice { get; set; }
		public GameHotKeyModel GameHotKey { get; set; }
		public GameSoundModel GameSound { get; set; }

		public SettingModel()
		{
			ClientNormal = new ClientNormalModel();
			ClientAlarm = new ClientAlarmModel();
			ClientChat = new ClientChatModel();
			ClientSound = new ClientSoundModel();
			ClientVoice = new ClientVoiceModel();
			GameHotKey = new GameHotKeyModel();
			GameSound = new GameSoundModel();
		}
	}
}
