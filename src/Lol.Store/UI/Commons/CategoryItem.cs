using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Commons
{
    public class CategoryItem : ListBoxItem
    {
        #region DefaultStyleKey

        static CategoryItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CategoryItem), new FrameworkPropertyMetadata(typeof(CategoryItem)));
        }
        #endregion
    }
}
