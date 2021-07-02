using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Game.Sound
{
	public class GameSoundView : View
    {
        static GameSoundView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameSoundView), new FrameworkPropertyMetadata(typeof(GameSoundView)));
        }
    }
}
