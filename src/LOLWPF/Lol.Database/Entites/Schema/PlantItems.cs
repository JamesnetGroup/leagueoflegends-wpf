namespace Lol.Database.Entites.Schema
{
    public class PlantHeaders
    {
        public int Seq { get; set; }
        public int LootSeq { get; set; }
        public bool IsExpanded { get; set; } = true;
        public List<PlantItems> Children { get; set; }
        public string Header { get; set; }
        public Type Type => GetType();
    }

    public class PlantItems
    {
        public int Seq { get; set; }
        public int HeaderSeq { get; set; }
        public string Content { get; set; }
        public Type Type => GetType();
    }
}
