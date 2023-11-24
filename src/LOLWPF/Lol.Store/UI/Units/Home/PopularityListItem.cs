using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Units
{
    public class PopularityListItem : ListBoxItem
    {
        #region DefaultStyleKey

        static PopularityListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PopularityListItem), new FrameworkPropertyMetadata(typeof(PopularityListItem)));
        }
        #endregion
    }
}
