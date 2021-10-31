using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class GameType_Custom : ListBox
    {
        #region DefaultStyleKey

        static GameType_Custom()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameType_Custom), new FrameworkPropertyMetadata(typeof(GameType_Custom)));
        }
        #endregion
    }
}
