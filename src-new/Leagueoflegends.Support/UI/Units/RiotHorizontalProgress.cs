using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Leagueoflegends.Support.UI.Units;

public sealed class RiotHorizontalProgress : Control
{
    public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(double), typeof(RiotHorizontalProgress), new PropertyMetadata(0d, OnProgressChanged));

    public static readonly DependencyProperty MaximumProperty = DependencyProperty.Register("Maximum", typeof(double), typeof(RiotHorizontalProgress), new PropertyMetadata(100d, OnProgressChanged));

    public double Value
    {
        get { return (double)GetValue(ValueProperty); }
        set { SetValue(ValueProperty, value); }
    }

    public double Maximum
    {
        get { return (double)GetValue(MaximumProperty); }
        set { SetValue(MaximumProperty, value); }
    }

    private Rectangle _backgroundRect;
    private Rectangle _foregroundRect;

    public RiotHorizontalProgress()
    {
        this.DefaultStyleKey = typeof(RiotHorizontalProgress);
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        _backgroundRect = GetTemplateChild("PART_Background") as Rectangle;
        _foregroundRect = GetTemplateChild("PART_Foreground") as Rectangle;
        this.SizeChanged += HorizontalProgress_SizeChanged;
        UpdateProgressBar();
    }

    private static void OnProgressChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var control = d as RiotHorizontalProgress;
        control?.UpdateProgressBar();
    }

    private void HorizontalProgress_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        UpdateProgressBar();
    }

    private void UpdateProgressBar()
    {
        if (_foregroundRect != null && Maximum > 0)
        {
            double progress = (Value / Maximum).Clamp(0, 1);
            _foregroundRect.Width = this.ActualWidth * progress;
        }
    }
}

public static class DoubleExtensions
{
    public static double Clamp(this double value, double min, double max)
    {
        return (value < min) ? min : (value > max) ? max : value;
    }
}
