using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class StateBox : Control
    {
        static StateBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StateBox), new FrameworkPropertyMetadata(typeof(StateBox)));
        }
    }
}
