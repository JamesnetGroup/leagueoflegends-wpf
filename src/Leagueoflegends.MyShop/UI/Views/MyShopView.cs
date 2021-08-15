using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.MyShop.UI.Views
{
    public class MyShopView : View
    {
        #region DefaultstyleKey

        static MyShopView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyShopView), new FrameworkPropertyMetadata(typeof(MyShopView)));
        }
        #endregion
    }
}
