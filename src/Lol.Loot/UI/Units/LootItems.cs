using System.Windows;
using System.Windows.Controls;

namespace Lol.Loot.UI.Units
{
    public class LootItems : Control
    {
        #region DefaultStyleKey

        static LootItems()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LootItems), new FrameworkPropertyMetadata(typeof(LootItems)));
        }
        #endregion
    }
}
