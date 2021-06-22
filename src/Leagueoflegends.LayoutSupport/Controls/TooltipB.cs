using Leagueoflegends.Controls;
using System.Windows;

namespace Leagueoflegends.LayoutSupport.Controls
{
	public class TooltipB : RiotTooltip
	{
		static TooltipB()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(TooltipB), new FrameworkPropertyMetadata(typeof(TooltipB)));
		}
	}
}
