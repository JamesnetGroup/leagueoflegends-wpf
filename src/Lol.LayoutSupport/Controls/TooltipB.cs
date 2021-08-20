using Lol.Controls;
using Lol.Controls.Primitives;
using System.Windows;

namespace Lol.LayoutSupport.Controls
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
