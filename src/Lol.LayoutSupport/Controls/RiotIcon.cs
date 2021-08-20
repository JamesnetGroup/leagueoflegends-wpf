using Lol.Controls.Primitives;
using System.Windows;

namespace Lol.LayoutSupport.Controls
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
