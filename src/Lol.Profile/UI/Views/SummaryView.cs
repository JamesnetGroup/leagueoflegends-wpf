using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Profile.UI.Views
{
    public class SummaryView : JamesContent
    {
        static SummaryView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SummaryView), new FrameworkPropertyMetadata(typeof(SummaryView)));
        }
    }
}
