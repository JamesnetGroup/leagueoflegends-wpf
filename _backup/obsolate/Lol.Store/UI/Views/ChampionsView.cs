using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Store.UI.Views
{
    public class StoreChampionsContent : JamesContent
    {
        static StoreChampionsContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StoreChampionsContent), new FrameworkPropertyMetadata(typeof(StoreChampionsContent)));
        }
    }
}
