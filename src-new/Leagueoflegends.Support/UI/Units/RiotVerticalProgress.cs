using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Leagueoflegends.Support.UI.Units;

public sealed class RiotVerticalProgress : Control
{
    public static readonly DependencyProperty ValueProperty =
        DependencyProperty.Register("Value", typeof(double), typeof(RiotVerticalProgress), new PropertyMetadata(0d, OnValueChanged));

    public double Value
    {
        get { return (double)GetValue(ValueProperty); }
        set { SetValue(ValueProperty, value); }
    }

    private Rectangle _backgroundRect;
    private Rectangle _foregroundRect;

    public RiotVerticalProgress()
    {
        this.DefaultStyleKey = typeof(RiotVerticalProgress);
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();

        _backgroundRect = GetTemplateChild("PART_Background") as Rectangle;
        _foregroundRect = GetTemplateChild("PART_Foreground") as Rectangle;

        this.SizeChanged += ActivityBar_SizeChanged;
        UpdateBarHeight();
    }

    private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var control = d as RiotVerticalProgress;
        control?.UpdateBarHeight();
    }

    private void ActivityBar_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        UpdateBarHeight();
    }

    private void UpdateBarHeight()
    {
        if (_foregroundRect != null)
        {
            _foregroundRect.Height = this.ActualHeight * (Value / 100);
        }
    }
}
