using System.Windows;
using System.Windows.Controls;

namespace Lol.Main.UI.Units
{
    public class PlayButton : Button
    {
        #region DefaultStylekey

        static PlayButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PlayButton), new FrameworkPropertyMetadata(typeof(PlayButton)));
        }
        #endregion
    }
}
