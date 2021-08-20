using Lol.Controls;
using Lol.Controls.Primitives;
using System.Windows;

namespace Lol.LayoutSupport.Controls
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
