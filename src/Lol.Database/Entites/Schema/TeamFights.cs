namespace Lol.Database.Entites.Schema
{
    public class TeamFights
    {
        public int Seq { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Explain { get; set; }
        public bool IsPremium { get; set; }
        public string Image { get; set; }
        public bool IsFree { get; set; }

        public string MD5 => $"/Lol.Resources;component/Images/TFT/{Image}";
    }
}
