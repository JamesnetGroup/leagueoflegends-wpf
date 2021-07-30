using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class SoundControl : Control
    {
        static SoundControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SoundControl), new FrameworkPropertyMetadata(typeof(SoundControl)));
        }
    }
}
