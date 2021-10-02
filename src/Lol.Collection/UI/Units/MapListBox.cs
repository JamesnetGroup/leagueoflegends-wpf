using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class MapListBox : ListBox
    {
        #region DefaultStyleKey

        static MapListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MapListBox), new FrameworkPropertyMetadata(typeof(MapListBox)));
        }
        #endregion

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new MapListBoxItem();
        }
    }
}
