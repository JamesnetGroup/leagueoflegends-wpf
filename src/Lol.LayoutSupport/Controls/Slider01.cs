using Lol.Controls;
using Lol.Controls.Primitives;
using System.Windows;

namespace Lol.LayoutSupport.Controls
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
