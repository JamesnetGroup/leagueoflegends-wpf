using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Collection.Local.ViewModels;

public class ChampionsContentViewModel : ViewModelBase
{
    private int _proficiency;
    public int Proficiency
    {
        get => _proficiency;
        set => SetProperty(ref _proficiency, value);
    }

    private int _achieve;
    public int Achieve
    {
        get => _achieve;
        set => SetProperty(ref _achieve, value);
    }

    private List<Option> _filterOptions;
    public List<Option> FilterOptions
    {
        get => _filterOptions;
        set => SetProperty(ref _filterOptions, value);
    }

    private Option _selectedFilterOption;
    public Option SelectedFilterOption
    {
        get => _selectedFilterOption;
        set => SetProperty(ref _selectedFilterOption, value);
    }

    private List<Option> _sortOptions;
    public List<Option> SortOptions
    {
        get => _sortOptions;
        set => SetProperty(ref _sortOptions, value);
    }

    private Option _selectedSortOption;
    public Option SelectedSortOption
    {
        get => _selectedSortOption;
        set => SetProperty(ref _selectedSortOption, value);
    }

    private List<ChampionGroup> _champions;
    public List<ChampionGroup> Champions
    {
        get => _champions;
        set => SetProperty(ref _champions, value);
    }

    private readonly IChampStatsDataLoader _champData;
    private readonly IOptionDataLoader _optionData;

    public ChampionsContentViewModel(IChampStatsDataLoader champData, IOptionDataLoader optionData)
    {
        _champData = champData;
        _optionData = optionData;
        InitializeViewModel();
    }

    private void InitializeViewModel()
    {
        Proficiency = 282;
        Achieve = 343;
        LoadFilterAndSortOptions();
        LoadChampions();
    }

    private void LoadFilterAndSortOptions()
    {
        FilterOptions = _optionData.GetByCategory("FilterOptions");
        SortOptions = _optionData.GetByCategory("SortOptions");

        SelectedFilterOption = FilterOptions.FirstOrDefault();
        SelectedSortOption = SortOptions.FirstOrDefault();
    }

    private void LoadChampions()
    {
        var kvps = _champData.GetStatsByPosition();
        Champions = new List<ChampionGroup>(
            kvps.Select(kvp => new ChampionGroup
            {
                Header = kvp.Key,
                Children = kvp.Value
            })
        );
    }
}
