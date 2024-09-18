using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Navigate.Local.Datas;

public class MenuDataLoader : BaseResourceLoader<MenuModel, List<MenuModel>>, IMenuDataLoader
{
    protected override string AssemblyName => "Leagueoflegends.Support";
    protected override string ResourcePath => "Leagueoflegends.Support.Datas.Menus.yml";

    public List<MenuModel> LoadMenuItems() => LoadAndOrganize();

    protected override IEnumerable<MenuModel> ConvertToItems(YamlData rawData)
    {
        return rawData.Select(item => new MenuModel
        {
            Seq = item.GetValue<int>("seq"),
            Name = item.GetValue<string>("name"),
            Category = item.GetValue<string>("category"),
            IsUsed = item.GetValue<bool>("isUsed")
        });
    }

    protected override List<MenuModel> OrganizeItems(IEnumerable<MenuModel> menuItems)
    {
        return menuItems.Where(x=>x.IsUsed).OrderBy(m => m.Seq).ToList();
    }
}
