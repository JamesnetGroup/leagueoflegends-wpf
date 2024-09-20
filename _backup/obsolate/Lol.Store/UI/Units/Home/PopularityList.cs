using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Units
{
    public class PopularityList : ListBox
    {
        #region DefaultStyleKey

        static PopularityList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PopularityList), new FrameworkPropertyMetadata(typeof(PopularityList)));
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new PopularityListItem();
        }
        #endregion
    }
}
