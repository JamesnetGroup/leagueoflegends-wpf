using System.Windows;
using System.Windows.Controls;

namespace Lol.Friends.UI.Units
{
    public class RecentUserBox : ListBox
    {
        #region DefaultStyleKey

        static RecentUserBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RecentUserBox), new FrameworkPropertyMetadata(typeof(RecentUserBox)));
        }
        #endregion
    }
}
