using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.Client.UI.Units
{
	public class InputSetting : Control
	{
		#region DefaultStyleKey

		static InputSetting()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(InputSetting), new FrameworkPropertyMetadata(typeof(InputSetting)));
		}
		#endregion
	}
}
