using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Leagueoflegends.Support.UI.Units;
public class RiotSaleChampion : Button
{
    public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(RiotSaleChampion), new PropertyMetadata(null));
    public static readonly DependencyProperty DiscountProperty = DependencyProperty.Register("Discount", typeof(int), typeof(RiotSaleChampion), new PropertyMetadata(0));

    public ImageSource ImageSource
    {
        get { return (ImageSource)GetValue(ImageSourceProperty); }
        set { SetValue(ImageSourceProperty, value); }
    }

    public int Discount
    {
        get { return (int)GetValue(DiscountProperty); }
        set { SetValue(DiscountProperty, value); }
    }

    public RiotSaleChampion()
    { 
        DefaultStyleKey = typeof(RiotSaleChampion);
    }
}
