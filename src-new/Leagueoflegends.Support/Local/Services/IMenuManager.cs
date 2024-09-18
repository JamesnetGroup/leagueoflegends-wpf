using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Services;

public interface IMenuManager
{
    event Action<List<MenuModel>> NavigationChanged;
    event Action<string> OptionMenuChanged;
    void NavigateToOption(string subMenuItem);
    void NavigateToMenu(string mainMenu);
    void NavigateToMenu(MenuModel subMenuItem);
    List<MenuModel> GetMenuByCategory(string mainMenu);
    void OpenOverlay(string contentName);
    void CloseOverlay(string contentName);
}
