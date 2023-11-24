using System.Windows;
using Jamesnet.Wpf.Controls;

namespace Lol.Settings.Client.UI.Views
{
    public class SoundContent : JamesContent
    {

        static SoundContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SoundContent), new FrameworkPropertyMetadata(typeof(SoundContent)));
        }
    }
}
