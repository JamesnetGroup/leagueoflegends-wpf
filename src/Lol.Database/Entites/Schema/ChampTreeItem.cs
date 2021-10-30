namespace Lol.Database.Entites.Schema
{
    public class ChampHeaders
    {
        public int Seq { get; set; }
        public int ChampCbSeq { get; set; }
        public bool IsExpanded { get; set; } = true;
        public List<ChampItems> Children { get; set; }
        public string Header { get; set; }
        public Type Type => GetType();
    }

    public class ChampItems
    {
        public int Seq { get; set; }
        public int HeaderSeq { get; set; }
        public string Champ { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Insignia { get; set; }
        public string 영원석 { get; set; }
        public Type Type => GetType();
    }
}
