using System.Windows;

namespace Lol.LayoutSupport.Controls
{
    public class RiotGameButtonn : RiotButton
    {
        #region DefaultStyleKey

        static RiotGameButtonn()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotGameButtonn), new FrameworkPropertyMetadata(typeof(RiotGameButtonn)));
        }
        #endregion
    }
}
