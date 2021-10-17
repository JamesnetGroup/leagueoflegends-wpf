using System.Windows;
using System.Windows.Controls;

namespace Lol.Loot.UI.Units
{
    public class RightContent : Control
    {
        #region DefaultStyleKey

        static RightContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RightContent), new FrameworkPropertyMetadata(typeof(RightContent)));
        }
        #endregion
    }
}
