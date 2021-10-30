using System.Windows;
using System.Windows.Controls;

namespace Lol.MyShop.UI.Units
{
    public class ShopItem3 : Button
    {
        static ShopItem3()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ShopItem3), new FrameworkPropertyMetadata(typeof(ShopItem3)));
        }
    }
}
