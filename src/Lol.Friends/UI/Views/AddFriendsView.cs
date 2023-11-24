using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Friends.UI.Views
{
    public class AddFriendsView : JamesContent
    {
        static AddFriendsView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AddFriendsView), new FrameworkPropertyMetadata(typeof(AddFriendsView)));
        }
    }
}
