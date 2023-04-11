using DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives;
using System.Windows;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
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
