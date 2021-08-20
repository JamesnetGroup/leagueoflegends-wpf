namespace Lol.Data.Setting.Clients
{
    public class SoundModel
    {
        public bool MasterVolumeOn { get; set; } = true;
        public int MasterVolume { get; set; } = 70;
        public bool EffectVolumeOn { get; set; } = true;
        public int EffectVolume { get; set; } = 100;
        public bool SoundAroundOn { get; set; } = true;
        public bool SoundChampionSelect { get; set; } = true;
        public bool SoundChampionBan { get; set; } = true;
        public bool MusicVolumeOn { get; set; } = true;
        public int MusicVolume { get; set; } = 100;
        public bool MusicChampionSelect { get; set; } = true;
        public bool MusicLobby { get; set; } = true;
        public bool MusicLogin { get; set; } = true;

        public SoundModel()
        {
        }
    }
}
