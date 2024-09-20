using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Loot.UI.Views
{
    public class LootView : JamesContent
    {
        #region DefaultStyleKey

        static LootView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LootView), new FrameworkPropertyMetadata(typeof(LootView)));
        }
        #endregion
    }
}
