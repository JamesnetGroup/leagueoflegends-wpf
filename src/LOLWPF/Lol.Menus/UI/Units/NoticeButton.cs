using System.Windows;
using System.Windows.Controls;

namespace Lol.Menus.UI.Units
{
    public class NoticeButton : Button
    {
        static NoticeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NoticeButton), new FrameworkPropertyMetadata(typeof(NoticeButton)));
        }
    }
}
