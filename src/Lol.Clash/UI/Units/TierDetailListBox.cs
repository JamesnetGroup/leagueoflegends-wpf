using System.Windows;
using System.Windows.Controls;


namespace Lol.Clash.UI.Units
{
    public class TierDetailListBox : ListBox
    {
        #region DefaultStyleKey

        static TierDetailListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TierDetailListBox), new FrameworkPropertyMetadata(typeof(TierDetailListBox)));
        }
        #endregion
    }
}
