using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class ChampionItem : Control
    {
        #region DefaultStyleKey

        static ChampionItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChampionItem), new FrameworkPropertyMetadata(typeof(ChampionItem)));
        }
        #endregion
    }
}
