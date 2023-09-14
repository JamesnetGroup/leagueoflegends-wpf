using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Collection.UI.Views
{
    public class SkinView : JamesContent
    {
        static SkinView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SkinView), new FrameworkPropertyMetadata(typeof(SkinView)));
        }
    }
}
