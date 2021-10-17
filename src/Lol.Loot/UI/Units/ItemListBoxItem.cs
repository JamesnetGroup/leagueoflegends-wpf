using System.Windows;
using System.Windows.Controls;

namespace Lol.Loot.UI.Units
{
    public class ItemListBoxItem : ListBoxItem
    {
        #region DefaultStyleKey

        static ItemListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemListBoxItem), new FrameworkPropertyMetadata(typeof(ItemListBoxItem)));
        }
        #endregion
    }
}
