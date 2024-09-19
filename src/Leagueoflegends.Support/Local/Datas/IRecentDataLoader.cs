using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;

public interface IRecentDataLoader
{
    List<Recent> LoadRecents();
}
