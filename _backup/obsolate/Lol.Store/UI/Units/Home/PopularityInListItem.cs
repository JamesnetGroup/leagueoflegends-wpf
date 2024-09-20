using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Units
{
    public class PopularityInListItem : ListBoxItem
    {
        #region DefaultStyleKey

        static PopularityInListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PopularityInListItem), new FrameworkPropertyMetadata(typeof(PopularityInListItem)));
        }
        #endregion
    }
}
