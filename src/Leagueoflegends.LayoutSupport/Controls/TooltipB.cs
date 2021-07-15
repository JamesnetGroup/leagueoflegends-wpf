using Leagueoflegends.Controls;
using System.Windows;

namespace Leagueoflegends.LayoutSupport.Controls
{
	public class TooltipB : RiotTooltip
	{
		#region DefaultStyleKey

		static TooltipB()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(TooltipB), new FrameworkPropertyMetadata(typeof(TooltipB)));
		}
		#endregion
	}
}
