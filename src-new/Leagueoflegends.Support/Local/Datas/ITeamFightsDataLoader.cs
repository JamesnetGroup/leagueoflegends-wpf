using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;

public interface ITeamFightsDataLoader
{
    List<TeamFight> LoadTeamFights();
}
