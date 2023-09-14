using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Clash.UI.Views
{
    public class HubView : JamesContent
    {
        static HubView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HubView), new FrameworkPropertyMetadata(typeof(HubView)));
        }
    }
}
