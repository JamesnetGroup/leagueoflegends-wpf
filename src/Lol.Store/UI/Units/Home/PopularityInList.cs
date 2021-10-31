using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Units
{
    public class PopularityInList : ListBox
    {
        #region DefaultStyleKey

        static PopularityInList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PopularityInList), new FrameworkPropertyMetadata(typeof(PopularityInList)));
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new PopularityInListItem();
        }
        #endregion
    }
}
