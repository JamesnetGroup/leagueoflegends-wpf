using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Tft.Local.ViewModels;

public class TftContentViewModel : ViewModelBase
{
    private readonly ITeamFightsDataLoader _teamFightsData;
    private TeamFight _current;
    private List<TeamFight> _teamFights;

    public TeamFight Current
    {
        get => _current;
        set => SetProperty(ref _current, value);
    }

    public List<TeamFight> TeamFights
    {
        get => _teamFights;
        set => SetProperty(ref _teamFights, value);
    }

    public TftContentViewModel(ITeamFightsDataLoader teamFightsData)
    {
        _teamFightsData = teamFightsData;
        LoadTeamFights();
    }

    private void LoadTeamFights()
    {
        TeamFights = _teamFightsData.LoadTeamFights();
        Current = TeamFights.FirstOrDefault();
    }
}
