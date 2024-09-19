using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Collection.Local.ViewModels;

public class SkinsContentViewModel : ViewModelBase
{
    private readonly ISkinsDataLoader _skinsData;
    private readonly IOptionDataLoader _optionData;

    private int _ownedSkinsCount;
    private Option _selectedFilterOption;
    private Option _selectedSortOption;
    private List<SkinGroup> _champions;
    private List<Option> _filterOptions;
    private List<Option> _sortOptions;

    public int OwnedSkinsCount
    {
        get => _ownedSkinsCount;
        set => SetProperty(ref _ownedSkinsCount, value);
    }

    public List<Option> FilterOptions
    {
        get => _filterOptions;
        set => SetProperty(ref _filterOptions, value);
    }

    public Option SelectedFilterOption
    {
        get => _selectedFilterOption;
        set => SetProperty(ref _selectedFilterOption, value);
    }
    public List<Option> SortOptions
    {
        get => _sortOptions;
        set => SetProperty(ref _sortOptions, value);
    }

    public Option SelectedSortOption
    {
        get => _selectedSortOption;
        set => SetProperty(ref _selectedSortOption, value);
    }

    public List<SkinGroup> Champions
    {
        get => _champions;
        set => SetProperty(ref _champions, value);
    }

    public SkinsContentViewModel(ISkinsDataLoader skinsData, IOptionDataLoader optionData)
    {
        _skinsData = skinsData;
        _optionData = optionData;
        InitializeViewModel();
    }

    private void InitializeViewModel()
    {
        LoadFilterAndSortOptions();
        LoadChampions();

        OwnedSkinsCount = Champions.Count;
    }

    private void LoadFilterAndSortOptions()
    {
        FilterOptions = _optionData.GetByCategory("ChampionFilter");
        SortOptions = _optionData.GetByCategory("ChampionSort");

        SelectedFilterOption = FilterOptions.FirstOrDefault();
        SelectedSortOption = SortOptions.FirstOrDefault();
    }

    private void LoadChampions()
    {
        var kvps = _skinsData.GetSkinsGroupedByName();
        Champions = new List<SkinGroup>(
            kvps.Select(kvp => new SkinGroup
            {
                Header = $"{kvp.Key} Collection",
                Children = kvp.Value.Where(skin => skin.IsPurchased).ToList()
            })
            .Where(group => group.Children.Any())
        );
    }
}
