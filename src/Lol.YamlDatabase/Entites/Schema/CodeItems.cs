namespace Lol.YamlDatabase.Entites.Schema
{
    public class CodeItems
    {
        public int Seq { get; set; }
        public string Id { get; set; } = string.Empty;
        public string CodeId { get; set; } = string.Empty;
        public string ItemName { get; set; } = string.Empty;
        public string ItemValue { get; set; } = string.Empty;
        public string Explain { get; set; } = string.Empty;
        public int Sort { get; set; }
    }
}
