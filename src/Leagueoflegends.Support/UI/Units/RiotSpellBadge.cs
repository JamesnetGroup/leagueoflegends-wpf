using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotSpellBadge : Button
{
    public static readonly DependencyProperty SpellNameProperty = DependencyProperty.Register("SpellName", typeof(string), typeof(RiotSpellBadge), new PropertyMetadata(null));

    public string SpellName
    {
        get { return (string)GetValue(SpellNameProperty); }
        set { SetValue(SpellNameProperty, value); }
    }

    public RiotSpellBadge()
    {
        DefaultStyleKey = typeof(RiotSpellBadge);
    }
}
