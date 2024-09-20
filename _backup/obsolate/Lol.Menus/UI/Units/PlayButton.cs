using System.Windows;
using System.Windows.Controls;

namespace Lol.Menus.UI.Units
{
    public class PlayButton : Button
    {
        static PlayButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PlayButton), new FrameworkPropertyMetadata(typeof(PlayButton)));
        }
    }
}
