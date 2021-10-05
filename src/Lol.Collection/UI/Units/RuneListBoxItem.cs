using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class RuneListBoxItem : ListBoxItem
    {
        static RuneListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RuneListBoxItem), new FrameworkPropertyMetadata(typeof(RuneListBoxItem)));
        }
    }
}
