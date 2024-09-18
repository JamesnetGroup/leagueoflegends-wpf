using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Leagueoflegends.Support.UI.Units;
public class RiotSkinTierButton : Button
{
    public static readonly DependencyProperty ToolTipValueProperty = DependencyProperty.Register("ToolTipValue", typeof(string), typeof(RiotSkinTierButton), new PropertyMetadata(null));
    public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(RiotSkinTierButton), new PropertyMetadata(null));
    public static readonly DependencyProperty CountProperty = DependencyProperty.Register("Count", typeof(int), typeof(RiotSkinTierButton), new PropertyMetadata(0));

    public string ToolTipValue
    {
        get { return (string)GetValue(ToolTipValueProperty); }
        set { SetValue(ToolTipValueProperty, value); }
    }
    public ImageSource ImageSource
    {
        get { return (ImageSource)GetValue(ImageSourceProperty); }
        set { SetValue(ImageSourceProperty, value); }
    }
    public int Count
    {
        get { return (int)GetValue(CountProperty); }
        set { SetValue(CountProperty, value); }
    }
    public RiotSkinTierButton()
    {
        DefaultStyleKey = typeof(RiotSkinTierButton);
    }
}
