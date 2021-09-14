namespace Lol.Data.TeamFight
{
    public class TeamFightModel
    {
        public int Seq { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Explain { get; set; }
        public bool IsPremium { get; set; }
        public string MD5 { get; set; }
        public bool IsFree { get; set; }
    }
}
