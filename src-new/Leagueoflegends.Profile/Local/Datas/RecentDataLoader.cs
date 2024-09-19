using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Profile.Local.Datas;

public class RecentDataLoader : BaseResourceLoader<Recent, List<Recent>>, IRecentDataLoader
{
    protected override string AssemblyName => "Leagueoflegends.Support";
    protected override string ResourcePath => "Leagueoflegends.Support.Datas.Recents.yml";

    public List<Recent> LoadRecents() => LoadAndOrganize();

    protected override IEnumerable<Recent> ConvertToItems(YamlData rawData)
    {
        return rawData.Select(item => new Recent
        {
            Concept = item.GetValue<string>("concept"),
            ActivePercent = item.GetValue<int>("activepercent")
        });
    }

    protected override List<Recent> OrganizeItems(IEnumerable<Recent> Recents)
    {
        return Recents.ToList();
    }
}
