using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class ItemHotKey : Control
    {
        static ItemHotKey()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemHotKey), new FrameworkPropertyMetadata(typeof(ItemHotKey)));
        }
    }
}
