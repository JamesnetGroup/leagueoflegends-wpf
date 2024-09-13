using Jamesnet.Core;
using Leagueoflegends.Support.Local.Models;
using Leagueoflegends.Support.Local.Services;

namespace Leagueoflegends.Navigate.Local.ViewModels;
public class SubMenuContentViewModel : ViewModelBase
{
    private readonly ISubMenuNavigator _subMenuNavigator;
    private List<SubMenuItem> _subMenuItems;
    private SubMenuItem _selectedItem;

    public List<SubMenuItem> SubMenuItems
    {
        get => _subMenuItems;
        set => SetProperty(ref _subMenuItems, value);
    }

    public SubMenuItem SelectedItem
    {
        get => _selectedItem;
        set => SetProperty(ref _selectedItem, value, OnSelectedItemChanged);
    }

    public SubMenuContentViewModel(ISubMenuNavigator subMenuNavigator)
    {
        _subMenuNavigator = subMenuNavigator;
        _subMenuNavigator.SubMenuItemsUpdated += OnSubMenuItemsUpdated;
    }

    private void OnSelectedItemChanged()
    {
        if (_selectedItem != null)
        {
            _subMenuNavigator.NavigateToSubMenu(_selectedItem);
        }
    }

    private void OnSubMenuItemsUpdated(List<SubMenuItem> subMenuItems)
    {
        SubMenuItems = subMenuItems;
        SelectedItem = subMenuItems.FirstOrDefault();

        if(SelectedItem == null)
        {
            _subMenuNavigator.NavigateToMainMenu();
        }
    }
}
