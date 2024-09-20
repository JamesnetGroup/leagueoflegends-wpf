using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class FriendList : ListBox
    {
        #region DefaultStyleKey

        static FriendList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FriendList), new FrameworkPropertyMetadata(typeof(FriendList)));
        }
        #endregion
    }
}
