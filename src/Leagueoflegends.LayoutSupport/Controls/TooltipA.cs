using Leagueoflegends.Controls;
using System.Windows;

namespace Leagueoflegends.LayoutSupport.Controls
{
	public class TooltipA : RiotTooltip
	{
		static TooltipA()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(TooltipA), new FrameworkPropertyMetadata(typeof(TooltipA)));
		}
	}
}
