namespace Lol.Data.Setting.InGame
{
    public class GameSoundModel
    {
        public int MasterVolume { get; set; } = 100;
        public int MusicVolume { get; set; } = 80;
        public int AnnounceVolume { get; set; } = 80;
        public int VoiceVolume { get; set; } = 100;
        public int FXVolume { get; set; } = 50;
        public int EnvVolume { get; set; } = 100;
        public int SignalVolume { get; set; } = 30;
        public string MusicTheme { get; set; } = "Update Version";
        public bool MasterMute { get; set; } = false;
        public bool MusicMute { get; set; } = false;
        public bool AnnounceMute { get; set; } = false;
        public bool VoiceMute { get; set; } = false;
        public bool FXMute { get; set; } = false;
        public bool EnvMute { get; set; } = false;
        public bool SignalMute { get; set; } = false;
        public bool MuteAllSound { get; set; } = false;

        public GameSoundModel()
        {
        }
    }
}
