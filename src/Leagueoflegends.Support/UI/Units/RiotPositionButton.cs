using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotPositionButton : Button
{
    public static readonly DependencyProperty PositionProperty =
        DependencyProperty.Register(nameof(Position), typeof(string), typeof(RiotPositionButton),
            new PropertyMetadata(default(string), OnPositionChanged));

    public string Position
    {
        get { return (string)GetValue(PositionProperty); }
        set { SetValue(PositionProperty, value); }
    }

    public RiotPositionButton()
    {
        DefaultStyleKey = typeof(RiotPositionButton);
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateVisualState();
    }

    private static void OnPositionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is RiotPositionButton button)
        {
            button.UpdateVisualState();
        }
    }

    private void UpdateVisualState()
    {
        VisualStateManager.GoToState(this, Position, false);
    }
}
