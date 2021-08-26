using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Clash.UI.Views
{
	public class WinningTeam : View
	{
		static WinningTeam()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(WinningTeam), new FrameworkPropertyMetadata(typeof(WinningTeam)));
		}
	}
}
