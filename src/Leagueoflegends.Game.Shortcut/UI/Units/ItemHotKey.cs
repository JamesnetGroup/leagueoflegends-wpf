using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Game.Shortcut.UI.Units
{
	public class ItemHotKey : Control
    {
        static ItemHotKey()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemHotKey), new FrameworkPropertyMetadata(typeof(ItemHotKey)));
        }
    }
}
