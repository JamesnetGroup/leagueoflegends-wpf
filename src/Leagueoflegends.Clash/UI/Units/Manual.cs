using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Clash.UI.Units
{
	public class Manual : Control
    {
        #region DefaultStyleKey

        static Manual()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Manual), new FrameworkPropertyMetadata(typeof(Manual)));
        }
		#endregion
	}
}
