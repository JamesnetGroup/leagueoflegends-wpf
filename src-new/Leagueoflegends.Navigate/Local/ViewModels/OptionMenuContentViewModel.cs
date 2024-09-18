using Jamesnet.Core;
using Leagueoflegends.Support.Local.Services;
using System.Windows.Input;

namespace Leagueoflegends.Navigate.Local.ViewModels;
public class OptionMenuContentViewModel : ViewModelBase, IViewLoadable
{
    private readonly IMenuManager _menu;

    public ICommand MenuCommand { get; init; }

    public OptionMenuContentViewModel(IMenuManager menu)
    {
        _menu = menu;

        MenuCommand = new RelayCommand<string>(OnMenu);
    }

    private void OnMenu(string menuName)
    {
        _menu.NavigateToOption(menuName);
    }

    public void Loaded()
    {
        _menu.NavigateToOption("General");
    }
}
