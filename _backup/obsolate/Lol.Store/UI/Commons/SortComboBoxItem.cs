using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Commons
{
    public class SortComboBoxItem : ComboBoxItem
    {
        #region DefaultStyleKey

        static SortComboBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SortComboBoxItem), new FrameworkPropertyMetadata(typeof(SortComboBoxItem)));
        }
        #endregion
    }
}
