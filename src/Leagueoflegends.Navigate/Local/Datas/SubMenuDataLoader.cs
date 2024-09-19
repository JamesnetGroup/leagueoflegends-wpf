using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Navigate.Local.Datas;

public class SubMenuDataLoader : BaseResourceLoader<SubMenuItem, List<SubMenuItem>>, ISubMenuDataLoader
{
    protected override string AssemblyName => "Leagueoflegends.Support";
    protected override string ResourcePath => "Leagueoflegends.Support.Datas.SubMenus.yml";

    public List<SubMenuItem> LoadMenuItems() => LoadAndOrganize();

    protected override IEnumerable<SubMenuItem> ConvertToItems(YamlData rawData)
    {
        return rawData.Select(item => new SubMenuItem
        {
            Seq = item.GetValue<int>("seq"),
            Name = item.GetValue<string>("name"),
            Category = item.GetValue<string>("category")
        });
    }

    protected override List<SubMenuItem> OrganizeItems(IEnumerable<SubMenuItem> menuItems)
    {
        return menuItems.OrderBy(m => m.Seq).ToList();
    }
}
