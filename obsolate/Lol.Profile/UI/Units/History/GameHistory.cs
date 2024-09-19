using System.Windows;
using System.Windows.Controls;

namespace Lol.Profile.UI.Units
{
    public class GameHistory : ListBox
    {
        #region DefaultStyleKey

        static GameHistory()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameHistory), new FrameworkPropertyMetadata(typeof(GameHistory)));
        }
        #endregion
    }
}
