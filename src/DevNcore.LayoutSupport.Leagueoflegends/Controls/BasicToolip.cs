using DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives;
using System.Windows;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
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
