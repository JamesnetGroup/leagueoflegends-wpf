using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Collection.Local.ViewModels;

public class StoreChampContentViewModel : ViewModelBase
{
    private readonly IOptionDataLoader _optionData;
    private readonly IStoreChampDataLoader _storeChampData;
    private bool _isChampionsSelected;
    private bool _isEternalsSelected;
    private bool _isBundlesSelected;
    private Option _currentChamp;
    private Option _currentEternal;
    private Option _currentBundle;

    public bool IsChampionsSelected
    {
        get => _isChampionsSelected;
        set => SetProperty(ref _isChampionsSelected, value);
    }

    public bool IsEternalsSelected
    {
        get => _isEternalsSelected;
        set => SetProperty(ref _isEternalsSelected, value);
    }

    public bool IsBundlesSelected
    {
        get => _isBundlesSelected;
        set => SetProperty(ref _isBundlesSelected, value);
    }

    public Option CurrentChamp
    {
        get => _currentChamp;
        set => SetProperty(ref _currentChamp, value);
    }

    public Option CurrentEternal
    {
        get => _currentEternal;
        set => SetProperty(ref _currentEternal, value);
    }

    public Option CurrentBundle
    {
        get => _currentBundle;
        set => SetProperty(ref _currentBundle, value);
    }

    public List<Option> ChampOptions { get; set; }
    public List<Option> EternalOptions { get; set; }
    public List<Option> BundleOptions { get; set; }
    public List<StoreChamp> Champions { get; set; }

    public StoreChampContentViewModel(IOptionDataLoader optionData, IStoreChampDataLoader storeChampData)
    {
        _optionData = optionData;
        _storeChampData = storeChampData;
        IsChampionsSelected = true;

        LoadFilters();
        LoadChamps();
    }

    private void LoadFilters()
    {
        ChampOptions = _optionData.GetByCategory("ItemSortOptions");
        EternalOptions = _optionData.GetByCategory("ItemSortOptions");
        BundleOptions = _optionData.GetByCategory("ItemSortOptions");

        CurrentChamp = ChampOptions.FirstOrDefault();
        CurrentEternal = EternalOptions.FirstOrDefault();
        CurrentBundle = BundleOptions.FirstOrDefault();
    }

    private void LoadChamps()
    {
        Champions = _storeChampData.LoadStoreChamps();
    }
}
