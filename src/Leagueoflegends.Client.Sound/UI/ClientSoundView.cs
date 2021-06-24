using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Client.Sound.UI
{
	public class ClientSoundView : View
    {
        #region DefaultStyleKey

        static ClientSoundView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ClientSoundView), new FrameworkPropertyMetadata(typeof(ClientSoundView)));
        }
		#endregion
	}
}
