namespace Lol.Database.Entites.Schema
{
    public class Champions
    {
        public int Seq { get; set; }
        public int HeaderSeq { get; set; }
        public string Champ { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Insignia { get; set; }
        public int Eternals{ get; set; }
        public Type Type => GetType();
    }
}
