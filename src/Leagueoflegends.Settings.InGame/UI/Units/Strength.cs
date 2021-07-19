using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class Strength : Control
    {
        static Strength()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Strength), new FrameworkPropertyMetadata(typeof(Strength)));
        }
    }
}
