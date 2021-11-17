using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class FindRoom : Control
    {
        #region DefaultStyleKey

        static FindRoom()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FindRoom), new FrameworkPropertyMetadata(typeof(FindRoom)));
        }
        #endregion
    }
}
