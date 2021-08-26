using Lol.Controls.Primitives;
using System.Windows;

namespace Lol.LayoutSupport.Controls
{
	public class Slider02 : RiotSlider
	{
		#region DefaultStyleKey

		static Slider02()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(Slider02), new FrameworkPropertyMetadata(typeof(Slider02)));
		}
		#endregion
	}
}
