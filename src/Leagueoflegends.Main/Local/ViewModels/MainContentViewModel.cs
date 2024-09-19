using Jamesnet.Core;
using Leagueoflegends.Support.Local.Services;
using System.Windows.Input;

namespace Leagueoflegends.Main.Local.ViewModels;

public class MainContentViewModel : ViewModelBase, IViewLoadable
{
    private readonly IMenuManager _menu;
    private string _currentMenu;

    public string CurrentMenu
    {
        get => _currentMenu;
        set => SetProperty(ref _currentMenu, value);
    }

    public ICommand MenuCommand { get; private init; }
    public ICommand SettingsCommand { get; private init; }

    public MainContentViewModel(IMenuManager menu)
    {
        _menu = menu;
        MenuCommand = new RelayCommand<string>(SelectMenu);
        SettingsCommand = new RelayCommand(OpenSettings);
    }

    private void OpenSettings()
    {
        _menu.OpenOverlay("OptionContent");
    }

    private void SelectMenu(string menuName)
    {
        CurrentMenu = menuName;
        _menu.NavigateToMenu(menuName);
    }

    public void Loaded()
    {
        SelectMenu("HOME");
    }
}
