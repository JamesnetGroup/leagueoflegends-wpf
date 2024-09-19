using Leagueoflegends.Support.Local.Models;
using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotStoreChampListBoxItem : ListBoxItem
{
    public static readonly DependencyProperty IsLockedProperty =
        DependencyProperty.Register(nameof(IsLocked), typeof(bool), typeof(RiotStoreChampListBoxItem),
            new PropertyMetadata(false, OnIsLockedChanged));

    public bool IsLocked
    {
        get => (bool)GetValue(IsLockedProperty);
        set => SetValue(IsLockedProperty, value);
    }

    public RiotStoreChampListBoxItem()
    {
        DefaultStyleKey = typeof(RiotStoreChampListBoxItem);
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateVisualState(false);
    }

    private static void OnIsLockedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is RiotStoreChampListBoxItem item)
        {
            item.UpdateVisualState(true);
        }
    }

    private void UpdateVisualState(bool useTransitions)
    {
        string stateName = (bool)IsLocked ? "Locked" : "Unlocked";
        VisualStateManager.GoToState(this, stateName, useTransitions);
    }
}
