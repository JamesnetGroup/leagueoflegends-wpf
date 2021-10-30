using System.Windows;
using System.Windows.Controls;

namespace Lol.MyShop.UI.Units
{
    public class ShopItem2 : Button
    {
        static ShopItem2()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ShopItem2), new FrameworkPropertyMetadata(typeof(ShopItem2)));
        }
    }
}
