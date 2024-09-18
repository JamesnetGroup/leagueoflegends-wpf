using Leagueoflegends.Support.Local.Models;
using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public sealed class RiotIconButton : Button
{
    public static readonly DependencyProperty ControlTypeProperty = DependencyProperty.Register(nameof(IconType), typeof(SmallIconType), typeof(RiotIconButton), new PropertyMetadata(SmallIconType.Help, OnIconTypeChanged));

    public SmallIconType IconType
    {
        get => (SmallIconType)GetValue(ControlTypeProperty);
        set => SetValue(ControlTypeProperty, value);
    }

    public RiotIconButton()
    {
        this.DefaultStyleKey = typeof(RiotIconButton);
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateVisualState();
    }

    private static void OnIconTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is RiotIconButton button)
        {
            button.UpdateVisualState();
        }
    }

    private void UpdateVisualState()
    {
        VisualStateManager.GoToState(this, IconType.ToString(), false);
    }
}
