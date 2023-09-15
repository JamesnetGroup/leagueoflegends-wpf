using System.Windows;
using Jamesnet.Wpf.Controls;

namespace Lol.Settings.InGame.UI.Views
{
    public class HotKeyContent : JamesContent
    {
        static HotKeyContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HotKeyContent), new FrameworkPropertyMetadata(typeof(HotKeyContent)));
        }
    }
}
