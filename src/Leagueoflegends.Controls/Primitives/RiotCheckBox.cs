using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Controls
{
    public class RiotCheckBox : CheckBox
    {
        static RiotCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotCheckBox), new FrameworkPropertyMetadata(typeof(RiotCheckBox)));
        }
    }
}
