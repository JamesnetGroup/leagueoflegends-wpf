using System.Windows;
using Jamesnet.Wpf.Controls;

namespace Lol.Settings.Client.UI.Views
{
    public class VoiceContent : JamesContent
    {
        static VoiceContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VoiceContent), new FrameworkPropertyMetadata(typeof(VoiceContent)));
        }
    }
}
