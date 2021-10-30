using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class ConfirmButton2 : Button
    {
        #region DefaultStyleKey

        static ConfirmButton2()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ConfirmButton2), new FrameworkPropertyMetadata(typeof(ConfirmButton2)));
        }
        #endregion
    }
}
