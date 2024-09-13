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

    public static readonly DependencyProperty MenuIconProperty = DependencyProperty.Register("MenuIcon", typeof(string), typeof(RiotMainIconMenu), new PropertyMetadata(null));

    public RiotMainIconMenu()
    { 
        DefaultStyleKey = typeof(RiotMainIconMenu);
    }
}
    
