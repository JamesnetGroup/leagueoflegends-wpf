using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Store.UI.Units
{
	public class Category : ListBox
    {
        #region DefaultStyleKey

        static Category()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Category), new FrameworkPropertyMetadata(typeof(Category)));
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new CategoryItem();
        }
        #endregion
    }
}
