using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Store.UI.Views
{
    public class StoreLootView : JamesContent
    {
        static StoreLootView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StoreLootView), new FrameworkPropertyMetadata(typeof(StoreLootView)));
        }
    }
}
