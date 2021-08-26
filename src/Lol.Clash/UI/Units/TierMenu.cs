using System.Windows;
using System.Windows.Controls;


namespace Lol.Clash.UI.Units
{
    #region DefaultStyleKey

    public class TierMenu : ListBox
    {
        static TierMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TierMenu), new FrameworkPropertyMetadata(typeof(TierMenu)));
        }
    }
    #endregion
}
