using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Controls
{
    public class RiotTooltip : ToolTip
    {
        public static readonly DependencyProperty TextWrappingProperty = DependencyProperty.Register(
           "TextWrapping", typeof(TextWrapping), typeof(RiotTooltip), new PropertyMetadata(null));

        public static readonly DependencyProperty TextAlignmentProperty = DependencyProperty.Register(
            "TextAlignment", typeof(TextAlignment), typeof(RiotTooltip), new PropertyMetadata(null));

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
            "CornerRadius", typeof(CornerRadius), typeof(RiotTooltip), new PropertyMetadata(null));

        public TextWrapping TextWrapping
        {
            get { return (TextWrapping)this.GetValue(TextWrappingProperty); }
            set { this.SetValue(TextWrappingProperty, value); }
        }

        public TextAlignment TextAlignment
        {
            get { return (TextAlignment)this.GetValue(TextAlignmentProperty); }
            set { this.SetValue(TextAlignmentProperty, value); }
        }

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)this.GetValue(CornerRadiusProperty); }
            set { this.SetValue(CornerRadiusProperty, value); }
        }
    }
}
