using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class ConfirmButton : Button
    {
        #region DefaultStyleKey

        static ConfirmButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ConfirmButton), new FrameworkPropertyMetadata(typeof(ConfirmButton)));
        }
        #endregion
    }
}
