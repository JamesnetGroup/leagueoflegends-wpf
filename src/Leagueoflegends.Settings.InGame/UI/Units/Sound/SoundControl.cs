using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class SoundControl : Control
    {
        #region DefaultStyleKey

        static SoundControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SoundControl), new FrameworkPropertyMetadata(typeof(SoundControl)));
        }
		#endregion
	}
}
