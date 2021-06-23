using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.UI.Units
{
    public class WindowBar : Control
    {
		#region DefaultStyleKey

		static WindowBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowBar), new FrameworkPropertyMetadata(typeof(WindowBar)));
        }
		#endregion
    }
}
