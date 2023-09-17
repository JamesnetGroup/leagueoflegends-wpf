using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Menus.UI.Views
{
    public class MenuContent : JamesContent
    {
        static MenuContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MenuContent), new FrameworkPropertyMetadata(typeof(MenuContent)));
        }
    }
}
