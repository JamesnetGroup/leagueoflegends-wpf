using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Settings.Client.UI.Views
{
	public class VoiceView : View
    {
        #region DefaultStyleKey

        static VoiceView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VoiceView), new FrameworkPropertyMetadata(typeof(VoiceView)));
        }
		#endregion
	}
}
