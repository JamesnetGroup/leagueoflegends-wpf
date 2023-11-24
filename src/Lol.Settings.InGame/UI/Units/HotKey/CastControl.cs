using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.InGame.UI.Units
{
    public class CastControl : Control
    {
        #region DefaultStyleKey

        static CastControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CastControl), new FrameworkPropertyMetadata(typeof(CastControl)));
        }
        #endregion
    }
}
