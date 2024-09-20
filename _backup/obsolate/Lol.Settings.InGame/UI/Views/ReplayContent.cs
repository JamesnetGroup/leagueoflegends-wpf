using System.Windows;
using Jamesnet.Wpf.Controls;

namespace Lol.Settings.InGame.UI.Views
{
    public class ReplayContent : JamesContent
    {
        static ReplayContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ReplayContent), new FrameworkPropertyMetadata(typeof(ReplayContent)));
        }
    }
}
