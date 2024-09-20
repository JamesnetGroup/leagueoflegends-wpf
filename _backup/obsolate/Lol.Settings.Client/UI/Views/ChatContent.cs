using System.Windows;
using Jamesnet.Wpf.Controls;

namespace Lol.Settings.Client.UI.Views
{
    public class ChatContent : JamesContent
    {
        #region DefaultStyleKey

        static ChatContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChatContent), new FrameworkPropertyMetadata(typeof(ChatContent)));
        }
        #endregion
    }
}
