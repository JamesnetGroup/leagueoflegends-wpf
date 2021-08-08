using Leagueoflegends.Controls;
using System.Windows;

namespace Leagueoflegends.LayoutSupport.Controls
{
    public class TooltipA : RiotTooltip
    {
        #region DefaultStyleKey

        static TooltipA()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TooltipA), new FrameworkPropertyMetadata(typeof(TooltipA)));
        }
        #endregion
    }
}
