using DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives;
using System.Windows;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
{
    public class Slider01 : RiotSlider
    {
        #region DefaultStyleKey

        static Slider01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Slider01), new FrameworkPropertyMetadata(typeof(Slider01)));
        }
        #endregion
    }
}
