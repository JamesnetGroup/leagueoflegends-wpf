using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Commons
{
    public class StoreList : ListBox
    {
        #region DefaultStyleKey

        static StoreList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StoreList), new FrameworkPropertyMetadata(typeof(StoreList)));
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new StoreListItem();
        }
        #endregion
    }
}
