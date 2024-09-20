using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Collection.UI.Views
{
    public class ItemView : JamesContent
    {
        static ItemView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemView), new FrameworkPropertyMetadata(typeof(ItemView)));
        }
    }
}
