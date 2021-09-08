using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Clash.UI.Views
{
	public class WinnersView : View
	{
		static WinnersView()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(WinnersView), new FrameworkPropertyMetadata(typeof(WinnersView)));
		}
	}
}
