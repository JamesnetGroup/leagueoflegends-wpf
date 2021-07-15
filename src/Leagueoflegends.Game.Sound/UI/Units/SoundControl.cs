using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Game.Sound.Units
{
	public class SoundControl : Control
    {
        static SoundControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SoundControl), new FrameworkPropertyMetadata(typeof(SoundControl)));
        }
    }
}
