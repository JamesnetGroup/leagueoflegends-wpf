using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotWallpaper : Control
{
    public static readonly DependencyProperty MenuNameProperty = DependencyProperty.Register("MenuName", typeof(string), typeof(RiotWallpaper), new PropertyMetadata(null, OnMenuNameChanged));

    public string MenuName
    {
        get { return (string)GetValue(MenuNameProperty); }
        set { SetValue(MenuNameProperty, value); }
    }

    public RiotWallpaper()
    { 
        DefaultStyleKey = typeof(RiotWallpaper);
    }

    private static void OnMenuNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is RiotWallpaper wallpaper)
        {
            wallpaper.UpdateVisualState();
        }
    }

    private void UpdateVisualState()
    {
        switch (MenuName)
        {
            case "COLLECTION": VisualStateManager.GoToState(this, "ExpandedSidebarState", false); break;
            case "SHOP": VisualStateManager.GoToState(this, "ExpandedSidebarState", false); break;
            case "PROFILE": VisualStateManager.GoToState(this, "ExpandedSidebarState", false); break;
            case "CLASH": VisualStateManager.GoToState(this, "MediumSidebarState", false); break;
            case "TFT": VisualStateManager.GoToState(this, "NarrowSidebarState", false); break;
            default: VisualStateManager.GoToState(this, "DefaultState", false); break;
        }
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateVisualState();
    }
}
