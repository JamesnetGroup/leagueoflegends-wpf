using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Collection.Local.ViewModels;

public class GeneralContentViewModel : ViewModelBase, IViewLoadable
{
    private readonly IOptionDataLoader _optionData;
    private Option _currentWindowSize;
    private List<Option> _windowSizes;

    public Option CurrentWindowSize
    {
        get => _currentWindowSize;
        set => SetProperty(ref _currentWindowSize, value);
    }

    public List<Option> WindowSizes
    { 
        get => _windowSizes;
        set => SetProperty(ref _windowSizes, value);
    }

    public GeneralContentViewModel(IOptionDataLoader optionData)
    {
        _optionData = optionData;
    }

    public void Loaded()
    {
        WindowSizes = _optionData.GetByCategory("WindowSize");
        CurrentWindowSize= WindowSizes.FirstOrDefault();
    }
}
