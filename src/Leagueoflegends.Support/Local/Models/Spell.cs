namespace Leagueoflegends.Support.Local.Models;

public class Spell
{
    public int Seq { get; set; }
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public int Level { get; set; }
    public List<string> Types { get; set; }
    public string TypesString { get; set; }
    public string Content { get; set; }
    public int Delay { get; set; }
    public string ImageUrl { get; set; }
}
