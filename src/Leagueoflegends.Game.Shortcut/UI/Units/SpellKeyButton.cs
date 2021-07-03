using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Game.Shortcut.UI.Units
{
	public class SpellKeyButton : Control
    {
        static SpellKeyButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SpellKeyButton), new FrameworkPropertyMetadata(typeof(SpellKeyButton)));
        }
    }
}
