using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Profile.UI.Views
{
    public class HistoryView : JamesContent
    {
        static HistoryView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HistoryView), new FrameworkPropertyMetadata(typeof(HistoryView)));
        }
    }
}
