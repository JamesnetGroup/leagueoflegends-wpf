using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.UI.Units
{
    public class CurrentMenu : ContentControl
    {
        static CurrentMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CurrentMenu), new FrameworkPropertyMetadata(typeof(CurrentMenu)));
        }
    }
}
