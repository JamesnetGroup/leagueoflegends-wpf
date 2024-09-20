using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class RuneDetailListBox : ListBox
    {
        #region DefaultStyleKey

        static RuneDetailListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RuneDetailListBox), new FrameworkPropertyMetadata(typeof(RuneDetailListBox)));
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new RuneDetailListBoxItem();
        }
        #endregion
    }
}
