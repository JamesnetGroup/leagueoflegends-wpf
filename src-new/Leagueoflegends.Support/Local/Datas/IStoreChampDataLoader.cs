using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;

public interface IStoreChampDataLoader
{
    List<StoreChamp> LoadStoreChamps();
}
