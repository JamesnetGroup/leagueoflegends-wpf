using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Units
{
    public class TopRightContent : Control
    {
        #region DefaultStyleKey

        static TopRightContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TopRightContent), new FrameworkPropertyMetadata(typeof(TopRightContent)));
        }
        #endregion
    }
}
