using System.Windows;
using System.Windows.Controls;

namespace Lol.Clash.UI.Units
{
    public class ScheduleListBox : ListBox
    {
        static ScheduleListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ScheduleListBox), new FrameworkPropertyMetadata(typeof(ScheduleListBox)));
        }
    }
}
