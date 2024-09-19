using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotChampionAvatar : Button
{
    public static readonly DependencyProperty ChampionProperty = DependencyProperty.Register("Champion", typeof(string), typeof(RiotChampionAvatar), new PropertyMetadata(null));
    public static readonly DependencyProperty LevelProperty = DependencyProperty.Register("Level", typeof(int), typeof(RiotChampionAvatar), new PropertyMetadata(1));

    public string Champion
    {
        get { return (string)GetValue(ChampionProperty); }
        set { SetValue(ChampionProperty, value); }
    }

    public int Level
    {
        get { return (int)GetValue(LevelProperty); }
        set { SetValue(LevelProperty, value); }
    }

    public RiotChampionAvatar()
    {
        DefaultStyleKey = typeof(RiotChampionAvatar);
    }
}
