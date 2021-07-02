using Leagueoflegends.Data.Setting.Clients;
using Leagueoflegends.Data.Setting.Game;

namespace Leagueoflegends.Data.Setting
{
	public class SettingModel
	{ 
		public ClientNormalModel ClientNormal { get; set; }
		public ClientAlarmModel ClientAlarm { get; set; }
		public ClientChatModel ClientChat { get; set; }
		public ClientSoundModel ClientSound { get; set; }
		public ClientVoiceModel ClientVoice { get; set; }
		public GameShortcutModel GameShortcut { get; set; }

		public SettingModel()
		{
			ClientNormal = new ClientNormalModel();
			ClientAlarm = new ClientAlarmModel();
			ClientChat = new ClientChatModel();
			ClientSound = new ClientSoundModel();
			ClientVoice = new ClientVoiceModel();
			GameShortcut = new GameShortcutModel();
		}
	}
}
