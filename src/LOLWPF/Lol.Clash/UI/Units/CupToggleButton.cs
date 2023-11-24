using System.Windows;
using System.Windows.Controls.Primitives;

namespace Lol.Clash.UI.Units
{
    public class CupToggleButton : ToggleButton
    {
        #region DefaultStyleKey

        static CupToggleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CupToggleButton), new FrameworkPropertyMetadata(typeof(CupToggleButton)));
        }
        #endregion
    }
}
