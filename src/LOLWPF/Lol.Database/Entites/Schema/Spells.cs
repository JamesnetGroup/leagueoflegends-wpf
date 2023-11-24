namespace Lol.Database.Entites.Schema
{
    public class Spells
    {
        public int Seq { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public int Level { get; set; }
        public int[] PlayTypes { get; set; }
        public string Content { get; set; }
        public int Delay { get; set; }

        public string PlayTypeList => string.Join(", ", PlayTypeItems.Select(x => x.EngName.ToString()).ToArray());
        public IEnumerable<PlayTypes> PlayTypeItems { get; set; }
    }
}
