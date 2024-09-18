using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;

public interface IMatchHistoryDataLoader
{
    List<MatchHistory> LoadMatchHistories();
}
