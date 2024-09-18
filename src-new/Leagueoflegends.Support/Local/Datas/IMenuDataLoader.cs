using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;

public interface IMenuDataLoader
{
    List<MenuModel> LoadMenuItems();
}
