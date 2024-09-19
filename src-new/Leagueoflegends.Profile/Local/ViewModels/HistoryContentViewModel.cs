using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Profile.Local.ViewModels;

public class HistoryContentViewModel : ViewModelBase
{
    private readonly IMatchHistoryDataLoader _matchHistoryData;
    private readonly IPlayChampDataLoader _playChampData;
    private readonly IRecentDataLoader _RecentData;

    private List<MatchHistory> _matchHistories;
    private MatchHistory _currentHistory;
    private List<PlayChamp> _playChamps;
    private List<Recent> _Recents;

    public List<MatchHistory> MatchHistories
    {
        get => _matchHistories;
        set => SetProperty(ref _matchHistories, value);
    }

    public MatchHistory CurrentHistory
    {
        get => _currentHistory;
        set => SetProperty(ref _currentHistory, value);
    }

    public List<PlayChamp> PlayChamps
    {
        get => _playChamps;
        set => SetProperty(ref _playChamps, value);
    }

    public List<Recent> Recents
    {
        get => _Recents;
        set => SetProperty(ref _Recents, value);
    }

    public HistoryContentViewModel(IMatchHistoryDataLoader matchHistoryData, IPlayChampDataLoader playChampData, IRecentDataLoader recentData)
    {
        _matchHistoryData = matchHistoryData;
        _playChampData = playChampData;
        _RecentData = recentData;
        LoadData();
    }

    private void LoadData()
    {
        LoadMatchHistories();
        LoadPlayChamps();
        LoadRecents();
    }

    private void LoadMatchHistories()
    {
        MatchHistories = _matchHistoryData.LoadMatchHistories();
        CurrentHistory = MatchHistories.FirstOrDefault();
    }

    private void LoadPlayChamps()
    {
        PlayChamps = _playChampData.LoadPlayChamps();
    }

    private void LoadRecents()
    {
        Recents = _RecentData.LoadRecents();
    }
}
