using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.InGame.UI.Units
{
    public class GameControl : Control
    {
        #region DefaultStyleKey

        static GameControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameControl), new FrameworkPropertyMetadata(typeof(GameControl)));
        }
        #endregion
    }
}
