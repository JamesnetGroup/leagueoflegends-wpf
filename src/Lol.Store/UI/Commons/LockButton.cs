using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Commons
{
    public class LockButton : Button
    {
        #region DefaultStyleKey

        static LockButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LockButton), new FrameworkPropertyMetadata(typeof(LockButton)));
        }
        #endregion
    }
}
