using System.Windows;
using System.Windows.Controls;

namespace Lol.Loot.UI.Units
{
    public class LootLeftMenuItem : ListBoxItem
    {
        #region DefaultStyleKey

        static LootLeftMenuItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LootLeftMenuItem), new FrameworkPropertyMetadata(typeof(LootLeftMenuItem)));
        }
        #endregion
    }
}
