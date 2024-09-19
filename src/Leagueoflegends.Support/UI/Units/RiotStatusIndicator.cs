using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;
public class RiotStatusIndicator : Control
{
    public string IconType
    {
        get { return (string)GetValue(IconTypeProperty); }
        set { SetValue(IconTypeProperty, value); }
    }

    public int Value
    {
        get { return (int)GetValue(ValueProperty); }
        set { SetValue(ValueProperty, value); }
    }

    public static readonly DependencyProperty IconTypeProperty = DependencyProperty.Register("IconType", typeof(string), typeof(RiotStatusIndicator), new PropertyMetadata(null));
    public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(RiotStatusIndicator), new PropertyMetadata(0));

    public RiotStatusIndicator()
    {
        DefaultStyleKey = typeof(RiotStatusIndicator);
    }
}
