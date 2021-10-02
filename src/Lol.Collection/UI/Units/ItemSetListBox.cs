using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class ItemSetListBox : ListBox
    {
        #region DefaultStyleKey

        static ItemSetListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemSetListBox), new FrameworkPropertyMetadata(typeof(ItemSetListBox)));
        }
        #endregion

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new ItemSetListBoxItem();
        }
    }
}
