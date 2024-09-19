using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;

public interface ISubMenuDataLoader
{
    List<SubMenuItem> LoadMenuItems();
}
