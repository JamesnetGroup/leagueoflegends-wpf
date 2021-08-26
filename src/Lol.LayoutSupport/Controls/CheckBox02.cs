using Lol.Controls.Primitives;
using System.Windows;

namespace Lol.LayoutSupport.Controls
{
	public class CheckBox02 : RiotCheckBox
	{
		#region DefaultStyleKey

		static CheckBox02()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(CheckBox02), new FrameworkPropertyMetadata(typeof(CheckBox02)));
		}
		#endregion
	}
}
