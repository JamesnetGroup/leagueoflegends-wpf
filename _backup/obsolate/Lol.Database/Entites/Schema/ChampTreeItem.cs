namespace Lol.Database.Entites.Schema
{
    public class ChampTreeItem
    {
        public int Seq { get; set; }
        public int Role { get; set; }
        public bool IsExpanded { get; set; } = true;
        public List<Champions> Children { get; set; }
        public string Header { get; set; }
        public Type Type => GetType();
    }
}
