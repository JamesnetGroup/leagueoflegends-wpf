using System.Windows;
using Jamesnet.Wpf.Controls;

namespace Lol.Settings.Client.UI.Views
{
    public class AlarmContent : JamesContent
    {
        static AlarmContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AlarmContent), new FrameworkPropertyMetadata(typeof(AlarmContent)));
        }
    }
}
