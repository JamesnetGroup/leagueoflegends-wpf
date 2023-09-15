using System.Windows;
using Jamesnet.Wpf.Controls;

namespace Lol.Settings.InGame.UI.Views
{
    public class InterfaceContent : JamesContent
    {

        static InterfaceContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InterfaceContent), new FrameworkPropertyMetadata(typeof(InterfaceContent)));
        }
    }
}
