using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Client.Normal.UI
{
	public class ClientNormalView : View
    {
        #region DefaultStyleKey

        static ClientNormalView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ClientNormalView), new FrameworkPropertyMetadata(typeof(ClientNormalView)));
        }
		#endregion
	}
}
