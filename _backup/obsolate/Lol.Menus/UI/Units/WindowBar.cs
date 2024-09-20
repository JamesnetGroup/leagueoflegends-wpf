using System.Windows;
using System.Windows.Controls;

namespace Lol.Menus.UI.Units
{
    public class WindowBar : Control
    {
        static WindowBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowBar), new FrameworkPropertyMetadata(typeof(WindowBar)));
        }
    }
}
