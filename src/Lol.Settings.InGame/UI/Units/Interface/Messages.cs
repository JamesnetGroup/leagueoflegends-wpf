using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.InGame.UI.Units
{
    public class Messages : Control
    {
        #region DefaultStyleKey

        static Messages()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Messages), new FrameworkPropertyMetadata(typeof(Messages)));
        }
        #endregion
    }
}
