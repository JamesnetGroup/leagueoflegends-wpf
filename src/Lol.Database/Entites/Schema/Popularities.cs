namespace Lol.Database.Entites.Schema
{
    public class Popularities
    {
        public int Seq { get; set; }
        public string Header { get; set; }
        public List<PopularityDetails> Details { get; set; }
    }
}
