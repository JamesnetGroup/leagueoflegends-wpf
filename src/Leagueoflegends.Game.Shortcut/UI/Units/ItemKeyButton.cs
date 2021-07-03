using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Game.Shortcut.UI.Units
{
	public class ItemKeyButton : Control
    {
        static ItemKeyButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemKeyButton), new FrameworkPropertyMetadata(typeof(ItemKeyButton)));
        }
    }
}
