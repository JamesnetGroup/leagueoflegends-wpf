using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class Option : Control
    {
        static Option()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Option), new FrameworkPropertyMetadata(typeof(Option)));
        }
    }
}
