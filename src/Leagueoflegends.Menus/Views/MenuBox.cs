using Leagueoflegends.Menus.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Menus.Views
{
    public class MenuBox : Control
    {
        static MenuBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MenuBox), new FrameworkPropertyMetadata(typeof(MenuBox)));
        }
        
        public MenuBox()
        {
        }
    }
}
