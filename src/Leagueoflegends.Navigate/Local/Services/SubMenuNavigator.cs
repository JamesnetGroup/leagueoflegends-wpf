using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
using Leagueoflegends.Support.Local.Services;

namespace Leagueoflegends.Navigate.Local.Services;
public class SubMenuNavigator : ISubMenuNavigator
{
    private readonly ISubMenuDataLoader _dataLoader;
    private readonly ILayerManager _layerManager;
    private readonly IContainer _container;
    private List<SubMenuItem> _allMenuItems;
    private string _currentMainMenu;

    public event Action<List<SubMenuItem>> SubMenuItemsUpdated;

    public SubMenuNavigator(ISubMenuDataLoader dataLoader, ILayerManager layerManager, IContainer container)
    {
        _dataLoader = dataLoader;
        _layerManager = layerManager;
        _container = container;
        _allMenuItems = _dataLoader.LoadMenuItems();
    }

    public void UpdateSubMenuItems(string mainMenu)
    {
        _currentMainMenu = mainMenu;
        var subMenuItems = GetSubMenuItems(mainMenu);
        SubMenuItemsUpdated?.Invoke(subMenuItems);
    }

    public List<SubMenuItem> GetSubMenuItems(string mainMenu)
    {
        return _allMenuItems
            .Where(item => item.Category == mainMenu)
            .GroupBy(item => item.Name)
            .Select(group => group.First())
            .OrderBy(item => item.Seq)
            .ToList();
    }

    public void NavigateToSubMenu(SubMenuItem subMenuItem)
    {
        string category = subMenuItem.Category.ToPascal();
        string menuName = subMenuItem.Name.ToPascal();
        string contentName = $"{category}{menuName}Content";

        _container.TryResolve<IView>(contentName, out var view);
        _layerManager.Show("ContentLayer", view); 
    }

    public void NavigateToMainMenu()
    {
        string category = _currentMainMenu.ToPascal();
        string contentName = $"{category}Content";

        _container.TryResolve<IView>(contentName, out var view);
        _layerManager.Show("ContentLayer", view);
    }
}
