using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Units
{
    public class LootItemMenu : Control
    {
        #region DefaultStyleKey

        static LootItemMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LootItemMenu), new FrameworkPropertyMetadata(typeof(LootItemMenu)));
        }
        #endregion
    }
}
