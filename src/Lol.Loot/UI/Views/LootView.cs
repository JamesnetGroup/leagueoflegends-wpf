using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.Loot.UI.Views
{
    public class LootView : View
    {
        #region DefaultStyleKey

        static LootView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LootView), new FrameworkPropertyMetadata(typeof(LootView)));
        }
        #endregion
    }
}
