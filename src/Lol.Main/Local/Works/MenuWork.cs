namespace Lol.Main.Local.Work
{
    //private class MenuWork : ObservableObject
    //{
    //    private readonly Action<MainMenuInfo, List<SubMenuInfo>> _menuCommand;

    //    //private MainMenuInfo _currentMenu;
    //    //private MainMenuInfo CurrentMenu
    //    //{
    //    //    get => _currentMenu;
    //    //    set { _currentMenu = value; OnPropertyChanged(); }
    //    //}

    //    //private List<MainMenuInfo> Menus { get; }


    //    //private List<SubMenuInfo> TotalSubMenus { get; }

    //    //private MenuWork(Action<MainMenuInfo, List<SubMenuInfo>> menuCommand)
    //    //{
    //    //    _menuCommand = menuCommand;

    //    //    Menus = GetMenus();
    //    //    Menus.ForEach(x => x.MenuSelectCommand = new RelayCommand<MainMenuInfo>(MenuChanged));
    //    //    TotalSubMenus = GetSubMenus();

    //    //    CurrentMenu = Menus.First();
    //    //    MenuChanged(CurrentMenu);
    //    //}

    //    //internal void MenuChanged(MainMenuInfo obj)
    //    //{
    //    //    List<SubMenuInfo> subMenus = TotalSubMenus.Where(x => x.MainSeq == obj.Seq).ToList();
    //    //    _menuCommand.Invoke(obj, subMenus);
    //    //}

    //    //private List<SubMenuInfo> MenuChangedbyButtonClick(int seq)
    //    //{
    //    //    CurrentMenu = Menus[seq];
    //    //    List<SubMenuInfo> subMenus = TotalSubMenus.Where(x => x.MainSeq == CurrentMenu.Seq).ToList();

    //    //    return subMenus;
    //    //}
    //}
}