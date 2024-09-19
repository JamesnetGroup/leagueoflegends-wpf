using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class RuneDetailListBoxItem : ListBoxItem
    {
        #region DefaultStyleKey

        static RuneDetailListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RuneDetailListBoxItem), new FrameworkPropertyMetadata(typeof(RuneDetailListBoxItem)));
        }
        #endregion
    }
}
