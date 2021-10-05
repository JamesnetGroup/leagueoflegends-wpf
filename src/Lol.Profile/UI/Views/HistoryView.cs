using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Profile.UI.Views
{
    public class HistoryView : View
    {
        #region DefaultStyleKey

        static HistoryView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HistoryView), new FrameworkPropertyMetadata(typeof(HistoryView)));
        }
        #endregion
    }
}
