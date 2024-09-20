using System.Windows;
using System.Windows.Controls;

namespace Lol.MyShop.UI.Units
{
    public class ShopItem : Button
    {
        #region DependencyProperty

        public static readonly DependencyProperty DiscountRateProperty = DependencyProperty.Register("DiscountRate", typeof(string), typeof(ShopItem), new PropertyMetadata(""));
        public static readonly DependencyProperty ImageUrlProperty = DependencyProperty.Register("ImageUrl", typeof(string), typeof(ShopItem));
        #endregion

        #region DefaultStyleKey

        static ShopItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ShopItem), new FrameworkPropertyMetadata(typeof(ShopItem)));
        }
        #endregion

        #region DiscountRate

        public string DiscountRate
        {
            get => (string)GetValue(DiscountRateProperty);
            set => SetValue(DiscountRateProperty, value);
        }
        #endregion

        #region ImageUrl

        public string ImageUrl
        {
            get => (string)GetValue(ImageUrlProperty);
            set => SetValue(ImageUrlProperty, value);
        }
        #endregion
    }
}
