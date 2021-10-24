using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class ChampListBoxItem : ListBoxItem
    {
        #region DefaultStyleKey

        static ChampListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChampListBoxItem), new FrameworkPropertyMetadata(typeof(ChampListBoxItem)));
        }
        #endregion
    }
}
