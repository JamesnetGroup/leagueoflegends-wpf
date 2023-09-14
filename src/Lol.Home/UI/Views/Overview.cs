using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Home.UI.Views
{
    public class Overview : JamesContent
    {
        #region DefaultStyleKey

        static Overview()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Overview), new FrameworkPropertyMetadata(typeof(Overview)));
        }
        #endregion
    }
}
