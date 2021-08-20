using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Settings.InGame.UI.Views
{
    public class GameSoundView : View
    {
        #region DefaultStyleKey

        static GameSoundView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameSoundView), new FrameworkPropertyMetadata(typeof(GameSoundView)));
        }
        #endregion
    }
}
