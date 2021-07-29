using System.Windows;

namespace Leagueoflegends.LayoutSupport.Controls
{
	public class Slider02 : RiotSlider
    {
        #region DefaultStyleKey

        static Slider02()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Slider02), new FrameworkPropertyMetadata(typeof(Slider02)));
        }
		#endregion
	}
}
