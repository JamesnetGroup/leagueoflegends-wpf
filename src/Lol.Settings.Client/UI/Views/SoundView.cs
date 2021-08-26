using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Settings.Client.UI.Views
{
	public class SoundView : View
	{
		#region DefaultStyleKey

		static SoundView()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(SoundView), new FrameworkPropertyMetadata(typeof(SoundView)));
		}
		#endregion
	}
}
