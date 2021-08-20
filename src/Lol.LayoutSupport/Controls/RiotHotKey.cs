using System.Windows;
using System.Windows.Controls;

namespace Lol.LayoutSupport.Controls
{
    public class RiotHotKey : Button
    {
        #region DefaultStyleKey

        static RiotHotKey()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotHotKey), new FrameworkPropertyMetadata(typeof(RiotHotKey)));
        }
        #endregion
    }
}
