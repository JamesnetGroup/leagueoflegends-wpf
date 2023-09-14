using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.GameRoom.UI.Views
{
    public class JoinCustomView : JamesContent
    {
        static JoinCustomView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(JoinCustomView), new FrameworkPropertyMetadata(typeof(JoinCustomView)));
        }
    }
}
