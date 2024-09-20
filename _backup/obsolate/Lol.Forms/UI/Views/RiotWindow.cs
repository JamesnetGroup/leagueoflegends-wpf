using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Forms.UI.Views
{
    public class RiotWindow : JamesWindow
    {
        static RiotWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotWindow), new FrameworkPropertyMetadata(typeof(RiotWindow)));
        }
    }
}
