using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.Client.UI.Units
{
	public class InputPress : Control
	{
		#region DefaultStyleKey

		static InputPress()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(InputPress), new FrameworkPropertyMetadata(typeof(InputPress)));
		}
		#endregion
	}
}
