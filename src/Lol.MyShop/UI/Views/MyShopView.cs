using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.MyShop.UI.Views
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
