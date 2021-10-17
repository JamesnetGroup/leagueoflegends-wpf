using System.Windows;
using System.Windows.Controls;

namespace Lol.Loot.UI.Units
{
    public class CommonList : ListBox
    {
        #region DefaultStyleKey

        static CommonList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CommonList), new FrameworkPropertyMetadata(typeof(CommonList)));
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new CommonListBoxItem();
        }
        #endregion
    }
}
