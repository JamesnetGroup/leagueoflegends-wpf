using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Leagueoflegends.Support.UI.Units;
public class RiotNewsButton : Button
{
    public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(RiotNewsButton), new PropertyMetadata(null));
    public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(RiotNewsButton), new PropertyMetadata(string.Empty));
    public static readonly DependencyProperty ImageHeightProperty = DependencyProperty.Register("ImageHeight", typeof(double), typeof(RiotNewsButton), new PropertyMetadata(double.NaN));

    public ImageSource ImageSource
    {
        get { return (ImageSource)GetValue(ImageSourceProperty); }
        set { SetValue(ImageSourceProperty, value); }
    }

    public double ImageHeight
    {
        get { return (double)GetValue(ImageHeightProperty); }
        set { SetValue(ImageHeightProperty, value); }
    }

    public string Text
    {
        get { return (string)GetValue(TextProperty); }
        set { SetValue(TextProperty, value); }
    }

    public RiotNewsButton()
    { 
        DefaultStyleKey = typeof(RiotNewsButton);
    }
}


public class RiotTftNewsButton : RiotNewsButton
{
    public RiotTftNewsButton()
    {
        DefaultStyleKey = typeof(RiotTftNewsButton);
    }
}
