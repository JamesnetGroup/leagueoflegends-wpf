using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class InviteButton : Button
    {
        #region DefaultStyleKey

        static InviteButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InviteButton), new FrameworkPropertyMetadata(typeof(InviteButton)));
        }
        #endregion
    }
}
