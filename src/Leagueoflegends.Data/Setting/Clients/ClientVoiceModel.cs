using Leagueoflegends.Data.Enums;

namespace Leagueoflegends.Data.Setting.Clients
{
	public class ClientVoiceModel
	{
		public bool AutoConnecting { get; set; } = true;
		public bool Mute { get; set; } = true;
		public int InputVolume { get; set; } = 100;
		public string InputDevice { get; set; } = "";
		public VoiceInputMode InputMode { get; set; } = VoiceInputMode.InputStatus;
		public int NoiseControl { get; set; } = 50;
		public string TalkShortCut { get; set; } = "C";

		public ClientVoiceModel()
		{
		}
	}
}
