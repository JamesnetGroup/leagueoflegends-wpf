using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotWallpaper : Control
{
    public static readonly DependencyProperty MenuNameProperty = DependencyProperty.Register("MenuName", typeof(string), typeof(RiotWallpaper), new PropertyMetadata(null));

    public string MenuName
    {
        get { return (string)GetValue(MenuNameProperty); }
        set { SetValue(MenuNameProperty, value); }
    }

    public RiotWallpaper()
    { 
        DefaultStyleKey = typeof(RiotWallpaper);
    }
}
