using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotButton : Button
{
    public static readonly DependencyProperty IsLockedProperty = DependencyProperty.Register(nameof(IsLocked), typeof(bool), typeof(RiotButton), new PropertyMetadata(false, OnIsLockedChanged));

    public bool IsLocked
    {
        get { return (bool)GetValue(IsLockedProperty); }
        set { SetValue(IsLockedProperty, value); }
    }

    public RiotButton()
    {
        this.DefaultStyleKey = typeof(RiotButton);
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateVisualState();
    }

    private static void OnIsLockedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is RiotButton button)
        {
            button.UpdateVisualState();
        }
    }

    private void UpdateVisualState()
    {
        VisualStateManager.GoToState(this, IsLocked ? "Locked" : "Unlocked", true);
    }
}
