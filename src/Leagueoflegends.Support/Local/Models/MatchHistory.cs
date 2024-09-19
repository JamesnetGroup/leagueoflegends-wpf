namespace Leagueoflegends.Support.Local.Models;

public class MatchHistory
{
    public int Seq { get; set; }
    public string MapType { get; set; }
    public string GameMode { get; set; }
    public string Result { get; set; }
    public DateTime Timestamp { get; set; }
    public string Duration { get; set; }
    public string Date { get; set; }
    public int GoldEarned { get; set; }
    public int CreepScore { get; set; }
    public int Kills { get; set; }
    public int Deaths { get; set; }
    public int Assists { get; set; }
    public int ChampionLevel { get; set; }
    public string Champion { get; set; }
    public string SummonerSpell1 { get; set; }
    public string SummonerSpell2 { get; set; }
    public string Item1 { get; set; }
    public string Item2 { get; set; }
    public string Item3 { get; set; }
    public string Item4 { get; set; }
    public string Item5 { get; set; }
    public string Item6 { get; set; }
    public string WardItem { get; set; }
}
