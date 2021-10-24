using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class ItemQuickMenu : Control
    {
        #region DefaultStyleKey

        static ItemQuickMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemQuickMenu), new FrameworkPropertyMetadata(typeof(ItemQuickMenu)));
        }
        #endregion
    }
}
