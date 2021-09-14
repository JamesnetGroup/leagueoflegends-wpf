using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Settings.InGame.UI.Views
{
    public class HotKeyView : View
    {
        #region DefaultStyleKey

        static HotKeyView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HotKeyView), new FrameworkPropertyMetadata(typeof(HotKeyView)));
        }
        #endregion
    }
}
