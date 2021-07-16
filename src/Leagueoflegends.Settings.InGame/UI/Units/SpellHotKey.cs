using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class SpellHotKey : Control
    {
        static SpellHotKey()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SpellHotKey), new FrameworkPropertyMetadata(typeof(SpellHotKey)));
        }
    }
}
