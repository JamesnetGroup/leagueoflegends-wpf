using Leagueoflegends.Data.Menu;
using Leagueoflegends.Menus.ViewModels;

namespace Leagueoflegends.Main.ViewModels
{
    public class MainViewModel
    {
        public MenuBoxViewModel MenuBoxViewModel { get; }

        public MainViewModel()
        {
            MenuBoxViewModel = new MenuBoxViewModel(MenuSelected);
        }

        private void MenuSelected(MenuBoxModel menu)
        {
        }
    }
}
