using System.Windows;
using System.Windows.Controls;

namespace Lol.Profile.UI.Units
{
    public class ItemListBox : ListBox
    {
        #region DefaultStyleKey

        static ItemListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemListBox), new FrameworkPropertyMetadata(typeof(ItemListBox)));
        }
        #endregion
    }
}
