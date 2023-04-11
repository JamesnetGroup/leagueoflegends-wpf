using System.Windows;
using System.Windows.Controls.Primitives;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
{
    public class RiotToggleButton : ToggleButton
    {
        #region DefaultStyleKey

        static RiotToggleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotToggleButton), new FrameworkPropertyMetadata(typeof(RiotToggleButton)));
        }
        #endregion
    }
}
