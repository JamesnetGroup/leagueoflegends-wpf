using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Client.Chat.UI
{
	public class ClientChatView : View
    {
        #region DefaultStyleKey

        static ClientChatView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ClientChatView), new FrameworkPropertyMetadata(typeof(ClientChatView)));
        }
		#endregion
	}
}
