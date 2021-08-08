using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.MyShop.UI.Units
{
    public class ShopItem : Button
    {
        static ShopItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ShopItem), new FrameworkPropertyMetadata(typeof(ShopItem)));
        }
    }
}
