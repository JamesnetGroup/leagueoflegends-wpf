using Jamesnet.Core;
using Leagueoflegends.Support.Local.Services;
using System.Windows.Input;

namespace Leagueoflegends.Main.Local.ViewModels;
public class OptionContentViewModel : ViewModelBase
{
    private readonly IMenuManager _menu;
    private string _category;
    private string _menuName;

    public ICommand CloseCommand { get; private init; }

    public string Category
    {
        get => _category;
        set => SetProperty(ref _category, value);
    }

    public string MenuName
    {
        get => _menuName;
        set=> SetProperty(ref _menuName, value);
    }

    public OptionContentViewModel(IMenuManager menu)
    {
        _menu = menu;
        _menu.OptionMenuChanged += OptionMenuChanged;

        CloseCommand = new RelayCommand(Close);
    }

    private void OptionMenuChanged(string menuName)
    {
        MenuName = menuName.ToUpper();

        switch (MenuName)
        {
            case "GENERAL":
            case "NOTIFICATION":
            case "CHAT":
            case "SOUND":
            case "VOICE": Category = "CLIENT"; break;
            case "HOTKEY":
            case "VOLUME": Category = "IN-GAME"; break;
        }
    }

    private void Close()
    {
        _menu.CloseOverlay("OptionContent");
    }
}
