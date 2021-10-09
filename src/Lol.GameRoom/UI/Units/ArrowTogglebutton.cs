using System.Windows;
using System.Windows.Controls.Primitives;

namespace Lol.GameRoom.UI.Units
{
    public class ArrowTogglebutton : ToggleButton
    {
        #region DefaultStyleKey

        static ArrowTogglebutton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ArrowTogglebutton), new FrameworkPropertyMetadata(typeof(ArrowTogglebutton)));
        }
        #endregion
    }
}
