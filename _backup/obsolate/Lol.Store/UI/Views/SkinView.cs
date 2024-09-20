using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Store.UI.Views
{
    public class StoreSkinContent : JamesContent
    {

        static StoreSkinContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StoreSkinContent), new FrameworkPropertyMetadata(typeof(StoreSkinContent)));
        }
    }
}
