using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.UI.Units
{
    public class MenuList : ListBox
    {
        static MenuList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MenuList), new FrameworkPropertyMetadata(typeof(MenuList)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new MenuListItem();
        }
    }
}
