using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Units
{
    public class TFTItemMenu : Control
    {
        #region DefaultStyleKey

        static TFTItemMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TFTItemMenu), new FrameworkPropertyMetadata(typeof(TFTItemMenu)));
        }
        #endregion
    }
}
