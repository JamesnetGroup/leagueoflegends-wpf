using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.UI.Units
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
