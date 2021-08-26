using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.UI.Units
{
	public class CurrentContent : Control
	{
		static CurrentContent()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(CurrentContent), new FrameworkPropertyMetadata(typeof(CurrentContent)));
		}
	}
}
