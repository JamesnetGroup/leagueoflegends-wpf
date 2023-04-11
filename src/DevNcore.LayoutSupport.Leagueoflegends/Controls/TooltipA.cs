using DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives;
using System.Windows;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
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
