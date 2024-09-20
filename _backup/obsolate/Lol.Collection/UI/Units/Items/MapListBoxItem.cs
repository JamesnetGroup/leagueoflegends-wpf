using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class MapListBoxItem : ListBox
    {
        #region DefaultStyleKey

        static MapListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MapListBoxItem), new FrameworkPropertyMetadata(typeof(MapListBoxItem)));
        }
        #endregion
    }
}
