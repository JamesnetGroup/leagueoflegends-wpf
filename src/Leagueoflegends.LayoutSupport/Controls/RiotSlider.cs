using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.LayoutSupport.Controls
{
	public class RiotSlider : Slider
    {
        #region DefaultStyleKey

        static RiotSlider()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotSlider), new FrameworkPropertyMetadata(typeof(RiotSlider)));
        }
		#endregion
	}
}
