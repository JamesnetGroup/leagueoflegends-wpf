using System.Windows;
using System.Windows.Controls;

namespace Lol.Loot.UI.Units
{
    public class CommonListBoxItem : ListBoxItem
    {
        #region DefaultStyleKey

        static CommonListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CommonListBoxItem), new FrameworkPropertyMetadata(typeof(CommonListBoxItem)));
        }
        #endregion
    }
}
