using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Profile.Local.Datas;

public class MatchHistoryDataLoader : BaseResourceLoader<MatchHistory, List<MatchHistory>>, IMatchHistoryDataLoader
{
    protected override string AssemblyName => "Leagueoflegends.Support";
    protected override string ResourcePath => "Leagueoflegends.Support.Datas.MatchHistories.yml";

    public List<MatchHistory> LoadMatchHistories() => LoadAndOrganize();

    protected override IEnumerable<MatchHistory> ConvertToItems(YamlData rawData)
    {
        return rawData.Select(item => new MatchHistory
        {
            Seq = item.GetValue<int>("seq"),
            MapType = item.GetValue<string>("mapType"),
            GameMode = item.GetValue<string>("gameMode"),
            Result = item.GetValue<string>("result"),
            Timestamp = item.GetValue<DateTime>("timestamp"),
            Duration = item.GetValue<string>("duration"),
            Date = item.GetValue<string>("date"),
            GoldEarned = item.GetValue<int>("goldEarned"),
            CreepScore = item.GetValue<int>("creepScore"),
            Kills = item.GetValue<int>("kills"),
            Deaths = item.GetValue<int>("deaths"),
            Assists = item.GetValue<int>("assists"),
            ChampionLevel = item.GetValue<int>("championLevel"),
            Champion = item.GetValue<string>("champion"),
            SummonerSpell1 = item.GetValue<string>("summonerSpell1"),
            SummonerSpell2 = item.GetValue<string>("summonerSpell2"),
            Item1 = item.GetValue<string>("item1"),
            Item2 = item.GetValue<string>("item2"),
            Item3 = item.GetValue<string>("item3"),
            Item4 = item.GetValue<string>("item4"),
            Item5 = item.GetValue<string>("item5"),
            Item6 = item.GetValue<string>("item6"),
            WardItem = item.GetValue<string>("wardItem")
        });
    }

    protected override List<MatchHistory> OrganizeItems(IEnumerable<MatchHistory> matchHistories)
    {
        return matchHistories.ToList();
    }
}
