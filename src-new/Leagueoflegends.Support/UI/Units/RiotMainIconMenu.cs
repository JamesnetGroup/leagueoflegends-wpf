using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotMainIconMenu : RadioButton
{
    public string MenuIcon
    {
        get { return (string)GetValue(MenuIconProperty); }
        set { SetValue(MenuIconProperty, value); }
    }

    public static readonly DependencyProperty MenuIconProperty =
        DependencyProperty.Register("MenuIcon", typeof(string), typeof(RiotMainIconMenu), new PropertyMetadata(null, OnMenuIconChanged));

    public RiotMainIconMenu()
    { 
        DefaultStyleKey = typeof(RiotMainIconMenu);
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateVisualState();
    }

    private static void OnMenuIconChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is RiotMainIconMenu menu)
        {
            menu.UpdateVisualState();
        }
}
    
    private void UpdateVisualState()
    {
        string stateName = MenuIcon + "Icon";
        VisualStateManager.GoToState(this, stateName, false);
    }
}
