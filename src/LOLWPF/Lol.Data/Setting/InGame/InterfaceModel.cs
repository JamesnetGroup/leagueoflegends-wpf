namespace Lol.Data.Setting.InGame
{
    public class Health
    {
        public bool HealthBarVisible { get; set; } = true;
        public bool PilotStatusUI { get; set; } = true;
        public bool UsingHUD { get; set; } = true;
        public bool HealthBarVibration { get; set; } = true;
    }

    public class Alarm
    {
        public bool DamageScreenGlow { get; set; } = true;
        public bool PilotScreenGlow { get; set; } = true;
        public bool NewPlayerHelper { get; set; } = true;
        public bool CameraFocus { get; set; } = true;
    }

    public class Skill
    {
        public bool TargetBorder { get; set; } = true;
        public bool ViewTrack { get; set; } = true;
        public bool AttackIntersection { get; set; } = true;
        public bool DeactivateHUD { get; set; } = true;
        public bool ViewSkillConsume { get; set; } = true;
    }

    public class Minimap
    {
        public bool NeutralMonster { get; set; } = true;
        public bool LocateLeft { get; set; } = true;
        public bool AllowMove { get; set; } = true;
    }

    public class Score
    {
        public bool OrderbyPortrait { get; set; } = true;
        public bool ViewChampionName { get; set; } = true;
    }

    public class Chat
    {
        public bool ViewAllChatting { get; set; } = true;
        public bool ViewFriendChatting { get; set; } = true;
        public bool ViewTimeStamp { get; set; } = true;
    }

    public class Message
    {
        public bool TeamDamage { get; set; } = true;
        public bool Recover { get; set; } = true;
        public bool Gold { get; set; } = true;
        public bool Status { get; set; } = true;
        public bool Quest { get; set; } = true;
        public bool Mana { get; set; } = true;
        public bool EnemyDamage { get; set; } = true;
        public bool Avoid { get; set; } = true;
        public bool Level { get; set; } = true;
        public bool Special { get; set; } = true;
        public bool Score { get; set; } = true;
        public bool EXP { get; set; } = true;
    }

    public class InterfaceModel
    {
        public int InterfaceSize { get; set; } = 100;
        public int ChattingSize { get; set; } = 100;
        public int MinimapSize { get; set; } = 80;
        public Health Health { get; set; } = new Health();
        public string ShowName { get; set; } = "Summoner";
        public Alarm Alarm { get; set; } = new Alarm();
        public Skill Skill { get; set; } = new Skill();
        public string WaitTime { get; set; } = "All";
        public Minimap Minimap { get; set; } = new Minimap();
        public Score Score { get; set; } = new Score();
        public bool TeamFrameLocate { get; set; } = true;
        public Chat Chat { get; set; } = new Chat();
        public bool IgnoreEnemyEmotion { get; set; } = true;
        public string Emotion { get; set; } = "Off";
        public string EmotionSize { get; set; } = "Normal";
        public string Achieve { get; set; } = "OurTeam";
        public Message Message { get; set; } = new Message();
    }
}
