using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.Client.UI.Units
{
    public class InputPress : ContentControl
    {

        static InputPress()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InputPress), new FrameworkPropertyMetadata(typeof(InputPress)));
        }
    }
}
