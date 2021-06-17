using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.MyShop.Views
{
	public class MyShopView : View
    {
        static MyShopView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyShopView), new FrameworkPropertyMetadata(typeof(MyShopView)));
        }
    }
}
