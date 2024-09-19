using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
using Leagueoflegends.Support.Local.Services;

namespace Leagueoflegends.Clash.Local.ViewModels;

public class HubContentViewModel : ViewModelBase
{
    private readonly IMenuManager _menu;
    private readonly IScheduleDataLoader _scheduleData;

    private MenuModel _currentTabMenu;
    private List<MenuModel> _tabMenus;
    private List<Schedule> _schedules;

    public MenuModel CurrentTabMenu
    {
        get => _currentTabMenu;
        set => SetProperty(ref _currentTabMenu, value, CurrentTabMenuChanged);
    }

    private void CurrentTabMenuChanged()
    {
        Console.WriteLine($"RiotTabMenu Changed: {CurrentTabMenu?.Name}");
    }

    public List<MenuModel> TabMenus
    {
        get => _tabMenus;
        set => SetProperty(ref _tabMenus, value);
    }

    public List<Schedule> Schedules
    {
        get => _schedules;
        set => SetProperty(ref _schedules, value);
    }

    public HubContentViewModel(IMenuManager subMenu, IScheduleDataLoader scheduleData)
    {
        _menu = subMenu;
        _scheduleData = scheduleData;
        LoadSchedules();
    }

    private void LoadSchedules()
    {
        TabMenus = _menu.GetMenuByCategory("HUB");
        CurrentTabMenu = TabMenus.FirstOrDefault();
        Schedules = _scheduleData.LoadSchedules();
    }
}
