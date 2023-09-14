using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.MyShop.UI.Views
{
    public class MyShopView : JamesContent
    {
        #region DefaultstyleKey

        static MyShopView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyShopView), new FrameworkPropertyMetadata(typeof(MyShopView)));
        }
        #endregion
    }
}
