using System.Windows;
using System.Windows.Controls;

namespace Lol.Clash.UI.Units
{
    public class TierMenu : ListBox
    {
        #region DefaultStyleKey

        static TierMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TierMenu), new FrameworkPropertyMetadata(typeof(TierMenu)));
        }
        #endregion
    }
}
