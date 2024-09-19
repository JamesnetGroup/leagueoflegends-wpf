using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;

public interface IOptionDataLoader
{
    List<Option> LoadOptions();
    List<Option> GetByCategory(string category);
}
