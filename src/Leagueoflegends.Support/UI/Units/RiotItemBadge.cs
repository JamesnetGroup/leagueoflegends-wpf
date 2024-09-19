using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotItemBadge : Button
{
    public static readonly DependencyProperty ItemNameProperty = DependencyProperty.Register("ItemName", typeof(string), typeof(RiotItemBadge), new PropertyMetadata(null));

    public string ItemName
    {
        get { return (string)GetValue(ItemNameProperty); }
        set { SetValue(ItemNameProperty, value); }
    }

    public RiotItemBadge()
    {
        DefaultStyleKey = typeof(RiotItemBadge);
    }
}
