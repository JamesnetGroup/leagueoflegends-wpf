using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class GamePlay : Control
    {
        static GamePlay()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GamePlay), new FrameworkPropertyMetadata(typeof(GamePlay)));
        }
    }
}
