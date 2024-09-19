using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;

public interface IPlayChampDataLoader
{
    List<PlayChamp> LoadPlayChamps();
}
