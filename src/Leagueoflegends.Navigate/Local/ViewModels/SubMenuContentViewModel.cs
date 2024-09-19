using Jamesnet.Core;
using Leagueoflegends.Support.Local.Models;
using Leagueoflegends.Support.Local.Services;

namespace Leagueoflegends.Navigate.Local.ViewModels;
public class SubMenuContentViewModel : ViewModelBase
{
    private readonly IMenuManager _menu;
    private List<MenuModel> _subMenuItems;
    private MenuModel _selectedItem;

    public List<MenuModel> SubMenuItems
    {
        get => _subMenuItems;
        set => SetProperty(ref _subMenuItems, value);
    }

    public MenuModel SelectedItem
    {
        get => _selectedItem;
        set => SetProperty(ref _selectedItem, value, OnSelectedItemChanged);
    }

    public SubMenuContentViewModel(IMenuManager menu)
    {
        _menu = menu;
        _menu.NavigationChanged += OnNavigationChanged;
    }

    private void OnSelectedItemChanged()
    {
        _menu.NavigateToMenu(_selectedItem);
    }

    private void OnNavigationChanged(List<MenuModel> subMenuItems)
    {
        SubMenuItems = subMenuItems;
        SelectedItem = subMenuItems.FirstOrDefault();
    }
}
