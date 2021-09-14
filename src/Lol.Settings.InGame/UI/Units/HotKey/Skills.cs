using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.InGame.UI.Units
{
    public class Skills : Control
    {
        #region DefaultStyleKey

        static Skills()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Skills), new FrameworkPropertyMetadata(typeof(Skills)));
        }
        #endregion
    }
}
