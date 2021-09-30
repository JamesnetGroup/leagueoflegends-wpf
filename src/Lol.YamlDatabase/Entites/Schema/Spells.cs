namespace Lol.YamlDatabase.Entites.Schema
{
    public class Spells
    {
        public int Seq { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int[] PlayTypes { get; set; }
        public List<PlayTypes> PlayTypeItems { get; set; }
        public string Content { get; set; }
        public int Delay { get; set; }

        public string DisplayName => string.Join(", ", PlayTypeItems.Select(x => x.Name.ToString()).ToArray());
    }
}
