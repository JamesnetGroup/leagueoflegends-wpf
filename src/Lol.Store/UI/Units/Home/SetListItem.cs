using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Units
{
    public class SetListItem : ListBoxItem
    {
        #region DefaultStyleKey

        static SetListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SetListItem), new FrameworkPropertyMetadata(typeof(SetListItem)));
        }
        #endregion
    }
}
