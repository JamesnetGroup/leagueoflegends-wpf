using System.Windows;
using System.Windows.Controls;

namespace Lol.LayoutSupport.Controls
{
	public class BasicScroll : ScrollViewer
	{
		#region DefaultStyleKey

		static BasicScroll()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(BasicScroll), new FrameworkPropertyMetadata(typeof(BasicScroll)));
		}
		#endregion
	}
}
