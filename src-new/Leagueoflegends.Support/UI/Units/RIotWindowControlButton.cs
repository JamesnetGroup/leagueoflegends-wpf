using Leagueoflegends.Support.Local.Models;
using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public sealed class RiotWindowControlButton : Button
{
    public static readonly DependencyProperty ControlTypeProperty = DependencyProperty.Register(nameof(ControlType), typeof(WindowControlType), typeof(RiotWindowControlButton), new PropertyMetadata(WindowControlType.Help, OnControlTypeChanged));

    public WindowControlType ControlType
    {
        get => (WindowControlType)GetValue(ControlTypeProperty);
        set => SetValue(ControlTypeProperty, value);
    }

    public RiotWindowControlButton()
    {
        this.DefaultStyleKey = typeof(RiotWindowControlButton);
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateVisualState();
    }

    private static void OnControlTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is RiotWindowControlButton button)
        {
            button.UpdateVisualState();
        }
    }

    private void UpdateVisualState()
    {
        VisualStateManager.GoToState(this, ControlType.ToString(), false);
    }
}
