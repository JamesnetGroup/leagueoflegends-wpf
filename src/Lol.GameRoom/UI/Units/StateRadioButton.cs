using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class StateRadioButton : RadioButton
    {
        #region DefaultStyleKey

        static StateRadioButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StateRadioButton), new FrameworkPropertyMetadata(typeof(StateRadioButton)));
        }
        #endregion
    }
}
