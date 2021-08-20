namespace Lol.Data.Setting.InGame
{
    public class HotKeyModel
    {
        public string SkillKey1 { get; set; } = "A";
        public string SkillKey2 { get; set; } = "B";
        public string SkillKey3 { get; set; } = "C";
        public string SkillKey4 { get; set; } = "D";
        public string SpellKey1 { get; set; } = "E";
        public string SpellKey2 { get; set; } = "F";
        public string ItemKey1 { get; set; } = "G";
        public string ItemKey2 { get; set; } = "H";
        public string ItemKey3 { get; set; } = "I";
        public string ItemKey4 { get; set; } = "J";
        public string ItemKey5 { get; set; } = "K";
        public string ItemKey6 { get; set; } = "L";
        public string AccKey1 { get; set; } = "M";
        public bool ChangeToFourWay { get; set; } = true;
        public bool RunSkillInstantly { get; set; } = true;

        public HotKeyModel()
        {
        }
    }
}
