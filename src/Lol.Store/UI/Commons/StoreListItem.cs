using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Commons
{
    public class StoreListItem : ListBoxItem
    {
        #region DefaultStyleKey

        static StoreListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StoreListItem), new FrameworkPropertyMetadata(typeof(StoreListItem)));
        }
        #endregion
    }
}
