using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class StateToggleButton : Control
    {
        #region DefaultStyleKey

        static StateToggleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StateToggleButton), new FrameworkPropertyMetadata(typeof(StateToggleButton)));
        }
        #endregion
    }
}
