using System.Windows;
using System.Windows.Controls;

namespace Lol.Menus.UI.Units
{
    public class Currency : ContentControl
    {
        static Currency()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Currency), new FrameworkPropertyMetadata(typeof(Currency)));
        }
    }
}
