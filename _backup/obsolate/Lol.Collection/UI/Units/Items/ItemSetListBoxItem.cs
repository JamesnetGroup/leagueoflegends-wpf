using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class ItemSetListBoxItem : ListBoxItem
    {
        #region DefaultStyleKey

        static ItemSetListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemSetListBoxItem), new FrameworkPropertyMetadata(typeof(ItemSetListBoxItem)));
        }
        #endregion
    }
}
