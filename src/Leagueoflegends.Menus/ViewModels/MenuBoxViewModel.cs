using Leagueoflegends.Data.Menu;
using Leagueoflegends.Menus.Views;
using Leagueoflegends.Windowbase.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Leagueoflegends.Menus.ViewModels
{
    public class MenuBoxViewModel : ObservableObject
    {
        public Action<MenuBoxModel, MenuBox> MenuSelected { get; }
        public List<MenuBoxModel> Menus { get; }

        public MenuBoxViewModel(Action<MenuBoxModel> menuSelected)
        {
            Menus = GetMenus();
            Menus.ForEach(x => x.MenuSelectCommand = new RelayCommand<MenuBoxModel>(menuSelected));
        }

        #region GetMenus

        private List<MenuBoxModel> GetMenus()
        {
            var source = new List<MenuBoxModel>
            {
                new MenuBoxModel("HOME"),
                new MenuBoxModel("TFT"),
                new MenuBoxModel("CLASH")
            };
            return source;
        }
        #endregion
    }
}