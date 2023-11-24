using System.Windows;
using System.Windows.Controls;

namespace Lol.Loot.UI.Units
{
    public class ItemsSummary : ListBox
    {
        #region DefaultStyleKey

        static ItemsSummary()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemsSummary), new FrameworkPropertyMetadata(typeof(ItemsSummary)));
        }
        #endregion
    }
}
