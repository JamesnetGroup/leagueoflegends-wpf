using System.Windows;
using System.Windows.Controls;

namespace Lol.Menus.UI.Units
{
    public class SubMenu : ListBox
    {
        static SubMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SubMenu), new FrameworkPropertyMetadata(typeof(SubMenu)));
        }
    }
}
