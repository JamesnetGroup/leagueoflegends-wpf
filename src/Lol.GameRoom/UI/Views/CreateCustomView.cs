using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.GameRoom.UI.Views
{
    public class CreateCustomView : JamesContent
    {
        static CreateCustomView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CreateCustomView), new FrameworkPropertyMetadata(typeof(CreateCustomView)));
        }
    }
}
