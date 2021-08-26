using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Settings.Client.UI.Views
{
	public class AlarmView : View
	{
		#region DefaultStyleKey

		static AlarmView()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(AlarmView), new FrameworkPropertyMetadata(typeof(AlarmView)));
		}
		#endregion
	}
}
