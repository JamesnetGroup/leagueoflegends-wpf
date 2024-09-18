namespace Leagueoflegends.Support.Local.Models;

public class TeamFight
{
    public int Seq { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
    public string Explain { get; set; }
    public bool IsPremium { get; set; }
    public string Image { get; set; }
    public bool IsFree { get; set; }
}
