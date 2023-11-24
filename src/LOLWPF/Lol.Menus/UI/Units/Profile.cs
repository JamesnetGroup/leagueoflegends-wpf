using System.Windows;
using System.Windows.Controls;

namespace Lol.Menus.UI.Units
{
    public class Profile : ContentControl
    {
        static Profile()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Profile), new FrameworkPropertyMetadata(typeof(Profile)));
        }
    }
}
