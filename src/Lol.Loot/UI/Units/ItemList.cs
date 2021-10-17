using System.Windows;
using System.Windows.Controls;

namespace Lol.Loot.UI.Units
{
    public class ItemList : ListBox
    {
        #region DefaultStyleKey

        static ItemList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemList), new FrameworkPropertyMetadata(typeof(ItemList)));
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new ItemListBoxItem();
        }
        #endregion
    }
}
