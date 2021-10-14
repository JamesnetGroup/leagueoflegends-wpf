using Lol.Controls.Primitives;
using System.Windows;

namespace Lol.LayoutSupport.Controls
{
    public class CheckBox01 : RiotCheckBox
    {
        #region DefaultStyleKey

        static CheckBox01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CheckBox01), new FrameworkPropertyMetadata(typeof(CheckBox01)));
        }
        #endregion

        #region DependencyProperty

        public static readonly DependencyProperty TooltipPaddingProperty = DependencyProperty.Register(
            "TooltipPadding", typeof(Thickness), typeof(CheckBox01), new PropertyMetadata(default(Thickness)));
        #endregion

        #region TooltipPadding

        public Thickness TooltipPadding
        {
            get { return (Thickness)GetValue(TooltipPaddingProperty); }
            set { SetValue(TooltipPaddingProperty, value); }
        }
        #endregion
    }
}
