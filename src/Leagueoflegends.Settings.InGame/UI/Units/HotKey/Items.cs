using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class Items : Control
    {
        static Items()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Items), new FrameworkPropertyMetadata(typeof(Items)));
        }
    }
}
