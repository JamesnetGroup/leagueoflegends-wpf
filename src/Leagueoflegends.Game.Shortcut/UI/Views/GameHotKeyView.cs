using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Game.Shortcut.UI.Views
{
	public class GameHotKeyView : View
    {
        static GameHotKeyView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameHotKeyView), new FrameworkPropertyMetadata(typeof(GameHotKeyView)));
        }
    }
}
