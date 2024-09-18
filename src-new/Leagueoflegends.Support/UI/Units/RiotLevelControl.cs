
using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotLevelControl : ContentControl
{
    public static readonly DependencyProperty LevelProperty = DependencyProperty.Register("Level", typeof(int), typeof(RiotLevelControl), new PropertyMetadata(0));
    public static readonly DependencyProperty CurrentXPProperty = DependencyProperty.Register("CurrentXP", typeof(int), typeof(RiotLevelControl), new PropertyMetadata(0));
    public static readonly DependencyProperty MaxXPProperty = DependencyProperty.Register("MaxXP", typeof(int), typeof(RiotLevelControl), new PropertyMetadata(100));
    
    public RiotLevelControl()
    {
        DefaultStyleKey = typeof(RiotLevelControl);
    }

    public int Level
    {
        get { return (int)GetValue(LevelProperty); }
        set { SetValue(LevelProperty, value); }
    }

    public int CurrentXP
    {
        get { return (int)GetValue(CurrentXPProperty); }
        set { SetValue(CurrentXPProperty, value); }
    }

    public int MaxXP
    {
        get { return (int)GetValue(MaxXPProperty); }
        set { SetValue(MaxXPProperty, value); }
    }
}
