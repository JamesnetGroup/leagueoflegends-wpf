using System.Windows;
using System.Windows.Controls;

namespace Lol.Loot.UI.Units
{
    public class LootLeftMenu : ListBox
    {
        #region DefaultStyleKey

        static LootLeftMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LootLeftMenu), new FrameworkPropertyMetadata(typeof(LootLeftMenu)));
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new LootLeftMenuItem();
        }
        #endregion
    }
}
