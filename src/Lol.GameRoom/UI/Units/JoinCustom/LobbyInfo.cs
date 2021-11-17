using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class LobbyInfo : Control
    {
        #region DefaultStyleKey

        static LobbyInfo()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LobbyInfo), new FrameworkPropertyMetadata(typeof(LobbyInfo)));
        }
        #endregion
    }
}
