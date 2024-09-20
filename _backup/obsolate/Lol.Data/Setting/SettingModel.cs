using Lol.Data.Setting.Clients;
using Lol.Data.Setting.InGame;

namespace Lol.Data.Setting
{
    public class SettingModel
    {
        public GeneralModel General { get; set; }
        public AlarmModel Alarm { get; set; }
        public ChatModel Chat { get; set; }
        public SoundModel Sound { get; set; }
        public VoiceModel Voice { get; set; }
        public HotKeyModel HotKey { get; set; }
        public GameSoundModel GameSound { get; set; }
        public InterfaceModel Interface { get; set; }
        public GameModel Game { get; set; }

        public SettingModel()
        {
            General = new GeneralModel();
            Alarm = new AlarmModel();
            Chat = new ChatModel();
            Sound = new SoundModel();
            Voice = new VoiceModel();
            HotKey = new HotKeyModel();
            GameSound = new GameSoundModel();
            Interface = new InterfaceModel();
            Game = new GameModel();
        }
    }
}
