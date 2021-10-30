using System.Windows;
using System.Windows.Controls;

namespace Lol.MyShop.UI.Units
{
    public class ShopItem1 : Button
    {
        static ShopItem1()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ShopItem1), new FrameworkPropertyMetadata(typeof(ShopItem1)));
        }
    }
}
