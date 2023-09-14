using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.GameRoom.UI.Views
{
    public class SummonersRiftView : JamesContent
    {
        static SummonersRiftView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SummonersRiftView), new FrameworkPropertyMetadata(typeof(SummonersRiftView)));
        }
    }
}
