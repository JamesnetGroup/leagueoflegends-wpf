using Lol.Controls.Primitives;
using System.Windows;

namespace Lol.LayoutSupport.Controls
{
    public class BasicTooltip : RiotTooltip
    {
        #region DefaultStyleKey

        static BasicTooltip()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BasicTooltip), new FrameworkPropertyMetadata(typeof(BasicTooltip)));
        }
        #endregion
    }
}
