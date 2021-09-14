namespace Lol.Data.Setting.Clients
{
    public class VoiceModel
    {
        public bool AutoConnecting { get; set; } = true;
        public bool Mute { get; set; } = true;
        public int InputVolume { get; set; } = 100;
        public string InputDevice { get; set; } = "";
        public string InputMode { get; set; } = "Voice Activity";
        public int NoiseControl { get; set; } = 50;
        public string TalkShortCut { get; set; } = "C";

        public VoiceModel()
        {
        }
    }
}
