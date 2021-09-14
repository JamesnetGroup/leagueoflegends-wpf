using System.Windows;
using System.Windows.Controls;

namespace Lol.MyShop.UI.Units
{
    public class ShopItem : Button
    {
        static ShopItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ShopItem), new FrameworkPropertyMetadata(typeof(ShopItem)));
        }
    }
}
