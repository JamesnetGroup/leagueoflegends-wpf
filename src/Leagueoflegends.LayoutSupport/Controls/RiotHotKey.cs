using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.LayoutSupport.Controls
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
