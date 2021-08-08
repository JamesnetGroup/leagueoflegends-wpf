using Leagueoflegends.Controls;
using System.Windows;

namespace Leagueoflegends.LayoutSupport.Controls
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
