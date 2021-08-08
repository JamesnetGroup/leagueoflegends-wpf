using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Settings.InGame.UI.Views
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
