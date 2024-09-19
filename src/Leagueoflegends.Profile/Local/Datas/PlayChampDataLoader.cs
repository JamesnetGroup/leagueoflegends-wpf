using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Profile.Local.Datas;

public class PlayChampDataLoader : BaseResourceLoader<PlayChamp, List<PlayChamp>>, IPlayChampDataLoader
{
    protected override string AssemblyName => "Leagueoflegends.Support";
    protected override string ResourcePath => "Leagueoflegends.Support.Datas.PlayChamps.yml";

    public List<PlayChamp> LoadPlayChamps() => LoadAndOrganize();

    protected override IEnumerable<PlayChamp> ConvertToItems(YamlData rawData)
    {
        return rawData.Select(item => new PlayChamp
        {
            Seq = item.GetValue<int>("seq"),
            Champion = item.GetValue<string>("champion"),
            Percent = item.GetValue<int>("percent")
        });
    }

    protected override List<PlayChamp> OrganizeItems(IEnumerable<PlayChamp> playChamps)
    {
        return playChamps.ToList();
    }
}
