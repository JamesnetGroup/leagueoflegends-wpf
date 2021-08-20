using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.UI.Units
{
    public class MenuList : Control
    {
        static MenuList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MenuList), new FrameworkPropertyMetadata(typeof(MenuList)));
        }
    }
}
