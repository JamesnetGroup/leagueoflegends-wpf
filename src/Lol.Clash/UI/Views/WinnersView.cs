using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Clash.UI.Views
{
    public class WinnersView : JamesContent
    {
        static WinnersView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WinnersView), new FrameworkPropertyMetadata(typeof(WinnersView)));
        }
    }
}
