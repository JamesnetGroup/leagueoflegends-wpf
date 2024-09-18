
using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotLevelInfoControl : ContentControl
{
    public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(RiotLevelInfoControl), new PropertyMetadata(string.Empty));

    public static readonly DependencyProperty LevelProperty = DependencyProperty.Register("Level", typeof(int), typeof(RiotLevelInfoControl), new PropertyMetadata(0));

    public static readonly DependencyProperty DescriptionProperty = DependencyProperty.Register("Description", typeof(string), typeof(RiotLevelInfoControl), new PropertyMetadata(string.Empty));

    public string Title
    {
        get { return (string)GetValue(TitleProperty); }
        set { SetValue(TitleProperty, value); }
    }

    public int Level
    {
        get { return (int)GetValue(LevelProperty); }
        set { SetValue(LevelProperty, value); }
    }

    public string Description
    {
        get { return (string)GetValue(DescriptionProperty); }
        set { SetValue(DescriptionProperty, value); }
    }

    public RiotLevelInfoControl()
    {
        DefaultStyleKey = typeof(RiotLevelInfoControl);
    }
}
