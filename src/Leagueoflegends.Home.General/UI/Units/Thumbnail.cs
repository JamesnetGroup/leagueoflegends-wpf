using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Home.General.UI.Units
{
    public class Thumbnail : Control
    {
        static Thumbnail()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Thumbnail), new FrameworkPropertyMetadata(typeof(Thumbnail)));
        }
    }
}
