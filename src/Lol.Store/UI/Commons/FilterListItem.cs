using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Commons
{
    public class FilterListItem : ListBoxItem
    {
        #region DefaultStyleKey

        static FilterListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FilterListItem), new FrameworkPropertyMetadata(typeof(FilterListItem)));
        }
        #endregion
    }
}
