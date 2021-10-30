using System.Windows;
using System.Windows.Controls;

namespace Lol.MyShop.UI.Units
{
    public class ShopItem5 : Button
    {
        static ShopItem5()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ShopItem5), new FrameworkPropertyMetadata(typeof(ShopItem5)));
        }
    }
}
