using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class ChampListBox : TreeView
    {
        #region DefaultStyleKey

        static ChampListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChampListBox), new FrameworkPropertyMetadata(typeof(ChampListBox)));
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new ChampListBoxItem();
        }
        #endregion
    }
}
