using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Commons
{
    public class SearchTextBox : TextBox
    {
        #region DefaultStyleKey

        static SearchTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SearchTextBox), new FrameworkPropertyMetadata(typeof(SearchTextBox)));
        }
        #endregion
    }
}
