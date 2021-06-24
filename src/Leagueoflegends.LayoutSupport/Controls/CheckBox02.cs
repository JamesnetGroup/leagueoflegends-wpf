using Leagueoflegends.Controls;
using System.Windows;

namespace Leagueoflegends.LayoutSupport.Controls
{
	public class CheckBox02 : RiotCheckBox
    {
        static CheckBox02()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CheckBox02), new FrameworkPropertyMetadata(typeof(CheckBox02)));
        }
    }
}
