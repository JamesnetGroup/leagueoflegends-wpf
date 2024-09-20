using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.GameRoom.UI.Views
{
    public class CustomGameRoomView : View
    {
        #region DefalutStyleKey

        static CustomGameRoomView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomGameRoomView), new FrameworkPropertyMetadata(typeof(CustomGameRoomView)));
        }
        #endregion
    }
}
