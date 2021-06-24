using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.LayoutSupport.Controls
{
	public class RiotSlider : Slider
    {
        static RiotSlider()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotSlider), new FrameworkPropertyMetadata(typeof(RiotSlider)));
        }
    }
}
