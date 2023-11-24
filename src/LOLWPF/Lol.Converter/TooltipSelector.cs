using System.Windows;
using System.Windows.Controls;

namespace Lol.Converter
{

    public static class TooltipExtension
    {
        public static Style GetTooltipContainerStyle(DependencyObject obj)
        {
            return (Style)obj.GetValue(TooltipContainerStyleProperty);
        }

        public static void SetTooltipContainerStyle(DependencyObject obj, Style value)
        {
            obj.SetValue(TooltipContainerStyleProperty, value);
        }

        public static readonly DependencyProperty TooltipContainerStyleProperty =
            DependencyProperty.RegisterAttached(
                "TooltipContainerStyle", typeof(Style), typeof(TooltipExtension),
                new UIPropertyMetadata(null, OnTooltipContainerStylePropertyChanged));

        private static void OnTooltipContainerStylePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var uie = (FrameworkElement)d;
            uie.Resources.Add(typeof(ToolTip), e.NewValue);
        }
    }
}
