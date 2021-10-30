using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Units
{
    public class SetList : ListBox
    {
        #region DefaultStyleKey

        static SetList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SetList), new FrameworkPropertyMetadata(typeof(SetList)));
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new SetListItem();
        }
        #endregion
    }
}
