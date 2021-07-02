using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Game.Shortcut.UI.Views
{
	public class GameShortcutView : View
    {
        static GameShortcutView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameShortcutView), new FrameworkPropertyMetadata(typeof(GameShortcutView)));
        }
    }
}
