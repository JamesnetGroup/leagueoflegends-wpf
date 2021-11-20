using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Units
{
    public class EtcItemMenu : Control
    {
        #region DefaultStyleKey

        static EtcItemMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(EtcItemMenu), new FrameworkPropertyMetadata(typeof(EtcItemMenu)));
        }
        #endregion
    }
}
