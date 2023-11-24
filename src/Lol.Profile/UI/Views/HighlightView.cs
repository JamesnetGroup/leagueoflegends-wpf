using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Profile.UI.Views
{
    public class HighlightView : JamesContent
    {
        static HighlightView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HighlightView), new FrameworkPropertyMetadata(typeof(HighlightView)));
        }
    }
}
