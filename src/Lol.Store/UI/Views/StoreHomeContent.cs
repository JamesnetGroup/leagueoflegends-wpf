using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Store.UI.Views
{
    public class StoreHomeContent : JamesContent
    {
        static StoreHomeContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StoreHomeContent), new FrameworkPropertyMetadata(typeof(StoreHomeContent)));
        }
    }
}
