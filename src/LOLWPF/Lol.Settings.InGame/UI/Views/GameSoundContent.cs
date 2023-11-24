using System.Windows;
using Jamesnet.Wpf.Controls;

namespace Lol.Settings.InGame.UI.Views
{
    public class GameSoundContent : JamesContent
    {
        static GameSoundContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameSoundContent), new FrameworkPropertyMetadata(typeof(GameSoundContent)));
        }
    }
}
