using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.GameRoom.UI.Views
{
    public class CustomGameRoomView : View
    {
        #region DefalutStyleKey

        #endregion

        static CustomGameRoomView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomGameRoomView), new FrameworkPropertyMetadata(typeof(CustomGameRoomView)));
        }
    }
}
