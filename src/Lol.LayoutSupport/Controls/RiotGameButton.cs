using System.Windows;

namespace Lol.LayoutSupport.Controls
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
