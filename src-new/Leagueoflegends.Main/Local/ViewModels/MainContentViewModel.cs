using Jamesnet.Core;
using Leagueoflegends.Support.Local.Services;
using System.Windows.Input;

namespace Leagueoflegends.Main.Local.ViewModels;

public class MainContentViewModel : ViewModelBase, IViewLoadable
{
    private readonly ISubMenuNavigator _subNavigator;
    private string _currentMenu;

    public string CurrentMenu
    {
        get => _currentMenu;
        set => SetProperty(ref _currentMenu, value);
    }

    public ICommand SelectMenuCommand { get; }

    public MainContentViewModel(ISubMenuNavigator subNavigator)
    {
        _subNavigator = subNavigator;
        SelectMenuCommand = new RelayCommand<string>(SelectMenuItem);
    }

    private void SelectMenuItem(string menuName)
    {
        CurrentMenu = menuName;
        _subNavigator.UpdateSubMenuItems(menuName);
    }

    public void Loaded()
    {
        SelectMenuItem("HOME");
    }
}
