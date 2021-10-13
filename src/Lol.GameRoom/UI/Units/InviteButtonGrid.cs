using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class InviteButtonGrid : Control
    {
        #region DefaultStyleKey

        static InviteButtonGrid()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InviteButtonGrid), new FrameworkPropertyMetadata(typeof(InviteButtonGrid)));
        }
        #endregion
    }
}
