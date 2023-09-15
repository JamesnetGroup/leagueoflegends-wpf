using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.Client.UI.Units
{
    public class InputMode : ContentControl
    {

        static InputMode()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InputMode), new FrameworkPropertyMetadata(typeof(InputMode)));
        }
    }
}
