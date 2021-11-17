using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Units
{
    public class StoreList : ListBox
    {
        #region DefaultStyleKey

        static StoreList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StoreList), new FrameworkPropertyMetadata(typeof(StoreList)));
        }
        #endregion
    }
}
