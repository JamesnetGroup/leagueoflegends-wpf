using System.Windows;
using System.Windows.Controls;

namespace Lol.Profile.UI.Units
{
    public class HistoryListBox : ListBox
    {
        #region DefaultStyleKey

        static HistoryListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HistoryListBox), new FrameworkPropertyMetadata(typeof(HistoryListBox)));
        }
        #endregion
    }
}
