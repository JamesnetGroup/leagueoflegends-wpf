using DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives;
using System.Windows;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
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

        public static readonly DependencyProperty ToolTipVerticalOffsetProperty = DependencyProperty.Register(
            "ToolTipVerticalOffset", typeof(double), typeof(CheckBox01), new PropertyMetadata(0.0));

        public static readonly DependencyProperty ToolTipHorizonOffsetProperty = DependencyProperty.Register(
            "ToolTipHorizonOffset", typeof(double), typeof(CheckBox01), new PropertyMetadata(0.0));
        #endregion

        #region TooltipPadding

        public Thickness TooltipPadding
        {
            get { return (Thickness)GetValue(TooltipPaddingProperty); }
            set { SetValue(TooltipPaddingProperty, value); }
        }
        #endregion

        public double ToolTipVerticalOffset
        {
            get { return (double)this.GetValue(ToolTipVerticalOffsetProperty); }
            set { this.SetValue(ToolTipVerticalOffsetProperty, value); }
        }

        public double ToolTipHorizonOffset
        {
            get { return (double)this.GetValue(ToolTipHorizonOffsetProperty); }
            set { this.SetValue(ToolTipHorizonOffsetProperty, value); }
        }
    }
}
