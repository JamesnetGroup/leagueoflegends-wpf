using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.UI.Units
{
    public class CurrentContent : ContentControl
    {
        static CurrentContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CurrentContent), new FrameworkPropertyMetadata(typeof(CurrentContent)));
        }
    }
}
