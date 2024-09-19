using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotUserAvatar : Button
{
    public int Level
    {
        get { return (int)GetValue(LevelProperty); }
        set { SetValue(LevelProperty, value); }
    }

    public static readonly DependencyProperty LevelProperty = DependencyProperty.Register("Level", typeof(int), typeof(RiotUserAvatar), new PropertyMetadata(1));



    public RiotUserAvatar()
    {
        DefaultStyleKey = typeof(RiotUserAvatar);
    }
}
