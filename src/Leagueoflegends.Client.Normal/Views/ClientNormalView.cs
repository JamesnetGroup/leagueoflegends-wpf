using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Client.Normal.Views
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
