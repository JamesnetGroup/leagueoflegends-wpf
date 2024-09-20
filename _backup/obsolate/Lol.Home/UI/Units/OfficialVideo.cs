using System.Windows;
using System.Windows.Controls;

namespace Lol.Home.UI.Units
{
    public class OfficialVideo : Control
    {
        #region DefaultStyleKey

        static OfficialVideo()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(OfficialVideo), new FrameworkPropertyMetadata(typeof(OfficialVideo)));
        }
        #endregion
    }
}
