using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Settings.UI.Views
{
    public class SettingContent : JamesContent
    {
        static SettingContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SettingContent), new FrameworkPropertyMetadata(typeof(SettingContent)));
        }
    }
}
