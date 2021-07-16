using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Settings.Client.UI.Views
{
	public class SoundView : View
    {
        #region DefaultStyleKey

        static SoundView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SoundView), new FrameworkPropertyMetadata(typeof(SoundView)));
        }
		#endregion
	}
}
