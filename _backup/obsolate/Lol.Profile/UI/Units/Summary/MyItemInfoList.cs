using System.Windows;
using System.Windows.Controls;

namespace Lol.Profile.UI.Units
{
    public class MyItemInfoList : ListBox
    {
        #region DefaultStyleKey

        static MyItemInfoList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyItemInfoList), new FrameworkPropertyMetadata(typeof(MyItemInfoList)));
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new MyItemInfoListItem();
        }
        #endregion
    }
}
