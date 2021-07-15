using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Game.Shortcut.UI.Units
{
	public class SpellHotKey : Control
    {
        static SpellHotKey()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SpellHotKey), new FrameworkPropertyMetadata(typeof(SpellHotKey)));
        }
    }
}
