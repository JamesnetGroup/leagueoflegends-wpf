using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class Play : Control
    {
        static Play()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Play), new FrameworkPropertyMetadata(typeof(Play)));
        }
    }
}
