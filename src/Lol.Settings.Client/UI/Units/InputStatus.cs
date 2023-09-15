using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.Client.UI.Units
{
    public class InputStatus : ContentControl
    {

        static InputStatus()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InputStatus), new FrameworkPropertyMetadata(typeof(InputStatus)));
        }
    }
}
