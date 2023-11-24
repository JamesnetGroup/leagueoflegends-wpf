using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class TrophyButton : Button
    {
        #region DefaultStyleKey

        static TrophyButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TrophyButton), new FrameworkPropertyMetadata(typeof(TrophyButton)));
        }
        #endregion
    }
}
