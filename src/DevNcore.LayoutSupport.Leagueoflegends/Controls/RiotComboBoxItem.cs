using System.Windows;
using System.Windows.Controls;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
{
    public class RiotComboBoxItem : ComboBoxItem
    {
        #region DefaultStyleKey

        static RiotComboBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotComboBoxItem), new FrameworkPropertyMetadata(typeof(RiotComboBoxItem)));
        }
        #endregion
    }
}
