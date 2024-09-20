using System.Windows;
using System.Windows.Controls;

namespace Lol.Loot.UI.Units
{
    public class ItemsFilter : Control
    {
        #region DefaultStyleKey

        static ItemsFilter()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemsFilter), new FrameworkPropertyMetadata(typeof(ItemsFilter)));
        }
        #endregion
    }
}
