using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class Eternals : Control
    {
        static Eternals()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Eternals), new FrameworkPropertyMetadata(typeof(Eternals)));
        }
    }
}
