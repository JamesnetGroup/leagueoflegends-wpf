using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public sealed class RiotCircleButton : Button
{
    public static readonly DependencyProperty IconDataProperty = DependencyProperty.Register(nameof(IconData), typeof(string), typeof(RiotCircleButton), new PropertyMetadata(string.Empty, OnIconDataChanged));
    
    public string IconData
    {
        get => (string)GetValue(IconDataProperty);
        set => SetValue(IconDataProperty, value);
    }

    public RiotCircleButton()
    {
        this.DefaultStyleKey = typeof(RiotCircleButton);
    }

    private static void OnIconDataChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is RiotCircleButton button)
        {
            button.UpdateVisualState();
        }
    }

    private void UpdateVisualState()
    {
        switch (IconData)
        {
            case "Download": VisualStateManager.GoToState(this, "DownloadIcon", false); break;
            case "Gift": VisualStateManager.GoToState(this, "GiftIcon", false); break;
            case "User": VisualStateManager.GoToState(this, "UserIcon", false); break;
            default: VisualStateManager.GoToState(this, "DefaultIcon", false); break;
        }
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateVisualState();
    }
}
