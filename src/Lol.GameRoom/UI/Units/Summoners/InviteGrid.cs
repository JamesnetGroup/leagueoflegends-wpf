using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class InviteGrid : Control
    {
        #region DefaultStyleKey

        static InviteGrid()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InviteGrid), new FrameworkPropertyMetadata(typeof(InviteGrid)));
        }
        #endregion
    }
}
