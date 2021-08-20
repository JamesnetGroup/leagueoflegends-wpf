using System.Windows;
using System.Windows.Controls;

namespace Lol.Controls.Primitives
{
    public class RiotCheckBox : CheckBox
    {
        static RiotCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotCheckBox), new FrameworkPropertyMetadata(typeof(RiotCheckBox)));
        }
    }
}
