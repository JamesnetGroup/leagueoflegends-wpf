using Jamesnet.Foundation;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Tft.Local.Datas;

public class TeamFightsDataLoader : BaseResourceLoader<TeamFight, List<TeamFight>>, ITeamFightsDataLoader
{
    protected override string AssemblyName => "Leagueoflegends.Support";
    protected override string ResourcePath => "Leagueoflegends.Support.Datas.TeamFights.yml";

    public List<TeamFight> LoadTeamFights() => LoadAndOrganize();

    protected override IEnumerable<TeamFight> ConvertToItems(YamlData rawData)
    {
        return rawData.Select(item => new TeamFight
        {
            Seq = item.GetValue<int>("seq"),
            Name = item.GetValue<string>("name"),
            Level = item.GetValue<int>("level"),
            Explain = item.GetValue<string>("explain"),
            IsPremium = item.GetValue<bool>("isPremium"),
            Image = $"/Leagueoflegends.Support;component/Images/TeamFights/{item.GetValue<string>("image")}",
            IsFree = item.GetValue<bool>("isFree")
        });
    }

    protected override List<TeamFight> OrganizeItems(IEnumerable<TeamFight> teamFights)
    {
        return teamFights.OrderBy(tf => tf.Seq).ToList();
    }
}
