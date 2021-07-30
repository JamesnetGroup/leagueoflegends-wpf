using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class Size : Control
    {
        static Size()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Size), new FrameworkPropertyMetadata(typeof(Size)));
        }
    }
}
