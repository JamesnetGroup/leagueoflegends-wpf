using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class RoomInfo : Control
    {
        #region DefaultStyleKey

        static RoomInfo()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RoomInfo), new FrameworkPropertyMetadata(typeof(RoomInfo)));
        }
        #endregion
    }
}
