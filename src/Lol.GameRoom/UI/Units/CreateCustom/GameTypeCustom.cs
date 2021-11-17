using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class GameTypeCustom : ListBox
    {
        #region DefaultStyleKey

        static GameTypeCustom()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameTypeCustom), new FrameworkPropertyMetadata(typeof(GameTypeCustom)));
        }
        #endregion
    }
}
