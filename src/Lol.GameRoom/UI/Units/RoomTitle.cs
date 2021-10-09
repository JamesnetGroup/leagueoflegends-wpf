using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class RoomTitle : Control
    {
        #region DefaultStyleKey

        static RoomTitle()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RoomTitle), new FrameworkPropertyMetadata(typeof(RoomTitle)));
        }
        #endregion
    }
}
