using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
using Leagueoflegends.Support.Local.Services;

namespace Leagueoflegends.Navigate.Local.Services;
public class MenuManager : IMenuManager
{
    private readonly IMenuDataLoader _dataLoader;
    private readonly ILayerManager _layerManager;
    private readonly IContainer _container;
    private List<MenuModel> _allMenuItems;
    private string _currentMainMenu;

    public event Action<List<MenuModel>> NavigationChanged;
    public event Action<string> OptionMenuChanged;

    public MenuManager(IMenuDataLoader dataLoader, ILayerManager layerManager, IContainer container)
    {
        _dataLoader = dataLoader;
        _layerManager = layerManager;
        _container = container;
        _allMenuItems = _dataLoader.LoadMenuItems();
    }

    public void OpenOverlay(string contentName)
    {
        _container.TryResolve<IView>(contentName, out var view);
        _layerManager.Show("OverlayLayer", view);
    }

    public void CloseOverlay(string contentName)
    {
        _layerManager.Hide("OverlayLayer");
    }

    public List<MenuModel> GetMenuByCategory(string mainMenu)
    {
        return _allMenuItems
            .Where(item => item.Category == mainMenu)
            .GroupBy(item => item.Name)
            .Select(group => group.First())
            .OrderBy(item => item.Seq)
            .ToList();
    }

    public void NavigateToOption(string contentName)
    {
        string name = $"{contentName}Content";

        _container.TryResolve<IView>(name, out var view);
        _layerManager.Show("OptionContentLayer", view);

        OptionMenuChanged?.Invoke(contentName);
    }

    public void NavigateToMenu(string mainMenu)
    {
        _currentMainMenu = mainMenu;
        var subMenuItems = GetMenuByCategory(mainMenu);
        NavigationChanged?.Invoke(subMenuItems);
    }

    public void NavigateToMenu(MenuModel subMenuItem)
    {
        if (subMenuItem != null)
        {
            NavigateToSubMenu(subMenuItem);
        }
        else
        {
            NavigateToMainMenu();
        }
    }

    private void NavigateToMainMenu()
    {
        string category = _currentMainMenu.ToPascal();
        string contentName = $"{category}Content";

        _container.TryResolve<IView>(contentName, out var view);
        _layerManager.Show("ContentLayer", view);
    }

    private void NavigateToSubMenu(MenuModel subMenuItem)
    {
        string category = subMenuItem.Category.ToPascal();
        string menuName = subMenuItem.Name.ToPascal();
        string contentName = $"{category}{menuName}Content";

        _container.TryResolve<IView>(contentName, out var view);
        _layerManager.Show("ContentLayer", view);
    }
}
