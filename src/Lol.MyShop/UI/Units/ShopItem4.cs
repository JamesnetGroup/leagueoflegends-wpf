using System.Windows;
using System.Windows.Controls;

namespace Lol.MyShop.UI.Units
{
    public class ShopItem4 : Button
    {
        static ShopItem4()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ShopItem4), new FrameworkPropertyMetadata(typeof(ShopItem4)));
        }
    }
}
