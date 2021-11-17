using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class ConfirmButtonJoin : Button
    {
        #region DefaultStyleKey

        static ConfirmButtonJoin()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ConfirmButtonJoin), new FrameworkPropertyMetadata(typeof(ConfirmButtonJoin)));
        }
        #endregion
    }
}
