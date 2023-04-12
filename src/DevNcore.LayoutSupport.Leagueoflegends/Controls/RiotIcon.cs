using DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives;
using System.Windows;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
{
    public class RiotIcon : Icon
    {
        #region DefaultStyleKey

        static RiotIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotIcon), new FrameworkPropertyMetadata(typeof(RiotIcon)));
        }
        #endregion
    }
}
