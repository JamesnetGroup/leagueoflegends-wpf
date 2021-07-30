using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class Spells : Control
    {
        static Spells()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Spells), new FrameworkPropertyMetadata(typeof(Spells)));
        }
    }
}
