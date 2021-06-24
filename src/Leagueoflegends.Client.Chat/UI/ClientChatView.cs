using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Client.Chat.UI
{
	public class ClientChatView : View
    {
        static ClientChatView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ClientChatView), new FrameworkPropertyMetadata(typeof(ClientChatView)));
        }
    }
}
