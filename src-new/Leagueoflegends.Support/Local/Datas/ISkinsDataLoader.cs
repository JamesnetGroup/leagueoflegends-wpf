using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;

public interface ISkinsDataLoader
{
    List<Skin> LoadSkins();
    Dictionary<string, List<Skin>> GetSkinsGroupedByName();
}
