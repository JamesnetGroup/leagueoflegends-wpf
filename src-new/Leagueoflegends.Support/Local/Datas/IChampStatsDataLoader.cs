using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;

public interface IChampStatsDataLoader
{
    List<ChampionStats> LoadChampionStats();
    Dictionary<string, List<ChampionStats>> GetStatsByPosition();
}
