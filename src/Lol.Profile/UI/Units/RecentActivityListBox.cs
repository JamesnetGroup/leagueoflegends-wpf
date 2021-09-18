using System.Windows;
using System.Windows.Controls;

namespace Lol.Profile.UI.Units
{
    public class RecentActivityListBox : ListBox
    {
        static RecentActivityListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RecentActivityListBox), new FrameworkPropertyMetadata(typeof(RecentActivityListBox)));
        }
    }
}
