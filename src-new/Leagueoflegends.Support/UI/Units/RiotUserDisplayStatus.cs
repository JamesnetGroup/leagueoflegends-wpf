using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public sealed class RiotUserDisplayStatus : Control
{
    public static readonly DependencyProperty UserNameProperty = DependencyProperty.Register(nameof(UserName), typeof(string), typeof(RiotUserDisplayStatus), new PropertyMetadata(string.Empty));
    public static readonly DependencyProperty IsOnlineProperty = DependencyProperty.Register(nameof(IsOnline), typeof(bool), typeof(RiotUserDisplayStatus), new PropertyMetadata(true, OnIsOnlineChanged));

    public string UserName
    {
        get => (string)GetValue(UserNameProperty);
        set => SetValue(UserNameProperty, value);
    }

    public bool IsOnline
    {
        get => (bool)GetValue(IsOnlineProperty);
        set => SetValue(IsOnlineProperty, value);
    }

    public RiotUserDisplayStatus()
    {
        this.DefaultStyleKey = typeof(RiotUserDisplayStatus);
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateVisualState();
    }

    private static void OnIsOnlineChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is RiotUserDisplayStatus control)
        {
            control.UpdateVisualState();
        }
    }

    private void UpdateVisualState()
    {
        VisualStateManager.GoToState(this, IsOnline ? "Online" : "Offline", true);
    }
}
