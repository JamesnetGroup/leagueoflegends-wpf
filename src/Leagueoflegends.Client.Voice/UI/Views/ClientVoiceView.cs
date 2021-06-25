using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Client.Voice.UI.Views
{
	public class ClientVoiceView : View
    {
        #region DefaultStyleKey

        static ClientVoiceView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ClientVoiceView), new FrameworkPropertyMetadata(typeof(ClientVoiceView)));
        }
		#endregion
	}
}
