using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class GameType : ListBox
    {
        #region DefaultStyleKey

        static GameType()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameType), new FrameworkPropertyMetadata(typeof(GameType)));
        }
        #endregion
    }
}
