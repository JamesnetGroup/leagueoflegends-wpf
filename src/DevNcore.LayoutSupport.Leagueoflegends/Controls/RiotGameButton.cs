using System.Windows;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
{
    public class RiotGameButton : RiotButton
    {
        #region DefaultStyleKey

        static RiotGameButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotGameButton), new FrameworkPropertyMetadata(typeof(RiotGameButton)));
        }
        #endregion
    }
}
