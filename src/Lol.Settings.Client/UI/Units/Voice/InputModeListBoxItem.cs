using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.Client.UI.Units.Voice
{
    public class InputModeListBoxItem : ListBoxItem
    {
        static InputModeListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InputModeListBoxItem), new FrameworkPropertyMetadata(typeof(InputModeListBoxItem)));
        }
    }
}
