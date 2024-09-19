using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotMainMenu : RadioButton
{
    public string MenuName
    {
        get { return (string)GetValue(MenuNameProperty); }
        set { SetValue(MenuNameProperty, value); }
    }

    public string MenuIcon
    {
        get { return (string)GetValue(MenuIconProperty); }
        set { SetValue(MenuIconProperty, value); }
    }

    public static readonly DependencyProperty MenuNameProperty = DependencyProperty.Register("MenuName", typeof(string), typeof(RiotMainMenu), new PropertyMetadata(null));
    public static readonly DependencyProperty MenuIconProperty = DependencyProperty.Register("MenuIcon", typeof(string), typeof(RiotMainMenu), new PropertyMetadata(null));

    public RiotMainMenu()
    {
        DefaultStyleKey = typeof(RiotMainMenu);
    }
}
    
