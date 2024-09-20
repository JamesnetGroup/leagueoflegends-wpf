using System.Windows;
using Jamesnet.Wpf.Controls;

namespace Lol.Settings.UI.Views
{
    public class EmptyContent : JamesContent
    {
        static EmptyContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(EmptyContent), new FrameworkPropertyMetadata(typeof(EmptyContent)));
        }
    }
}
