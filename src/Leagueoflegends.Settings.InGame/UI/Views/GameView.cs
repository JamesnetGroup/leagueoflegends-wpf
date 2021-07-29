using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Settings.InGame.UI.Views
{
	public class GameView : View
    {
        static GameView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameView), new FrameworkPropertyMetadata(typeof(GameView)));
        }
    }
}
