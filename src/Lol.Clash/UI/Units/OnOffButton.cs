using System.Windows;
using System.Windows.Controls.Primitives;

namespace Lol.Clash.UI.Units
{
	public class OnOffButton : ToggleButton
	{
		#region DefaultStyleKey

		static OnOffButton()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(OnOffButton), new FrameworkPropertyMetadata(typeof(OnOffButton)));
		}
		#endregion
	}
}
