using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Home.UI.Views
{
    public class AvatarView : JamesContent
    {
        static AvatarView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AvatarView), new FrameworkPropertyMetadata(typeof(AvatarView)));
        }
    }
}
