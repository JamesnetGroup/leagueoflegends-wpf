using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.Client.UI.Units
{
    public class InputModeListBox : ListBox
    {
        static InputModeListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InputModeListBox), new FrameworkPropertyMetadata(typeof(InputModeListBox)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new InputModeListBoxItem ();
        }
    }
}
