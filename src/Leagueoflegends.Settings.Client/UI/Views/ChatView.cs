using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Settings.Client.UI.Views
{
    public class ChatView : View
    {
        #region DefaultStyleKey

        static ChatView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChatView), new FrameworkPropertyMetadata(typeof(ChatView)));
        }
        #endregion
    }
}
