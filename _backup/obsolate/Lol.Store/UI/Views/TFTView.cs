using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Store.UI.Views
{
    public class TFTView : JamesContent
    {
        static TFTView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TFTView), new FrameworkPropertyMetadata(typeof(TFTView)));
        }
    }
}
