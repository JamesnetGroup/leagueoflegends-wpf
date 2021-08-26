using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Main.UI.Units
{
	public class EmptyContent : View
	{
		#region DefaultStyleKey

		static EmptyContent()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(EmptyContent), new FrameworkPropertyMetadata(typeof(EmptyContent)));
		}
		#endregion
	}
}
