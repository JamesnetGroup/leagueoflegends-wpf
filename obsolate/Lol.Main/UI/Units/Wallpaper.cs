using System.Windows;
using System.Windows.Controls;

namespace Lol.Main.UI.Units
{
    public class Wallpaper : Control
    {
        static Wallpaper()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Wallpaper), new FrameworkPropertyMetadata(typeof(Wallpaper)));
        }
    }
}
