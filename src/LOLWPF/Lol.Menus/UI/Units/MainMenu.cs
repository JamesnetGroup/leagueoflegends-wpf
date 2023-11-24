using System.Windows;
using System.Windows.Controls;

namespace Lol.Menus.UI.Units
{
    public class MainMenu : Control
    {
        static MainMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainMenu), new FrameworkPropertyMetadata(typeof(MainMenu)));
        }
    }
}