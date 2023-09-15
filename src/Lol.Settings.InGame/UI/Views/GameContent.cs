using System.Windows;
using Jamesnet.Wpf.Controls;

namespace Lol.Settings.InGame.UI.Views
{
    public class GameContent : JamesContent
    {
        static GameContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameContent), new FrameworkPropertyMetadata(typeof(GameContent)));
        }
    }
}
